using CourseWorkPIPS.Services.IServ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using CourseWorkPIPS.Models.Enums;
using CourseWorkPIPS.Models;
using OfficeOpenXml;
using Microsoft.Extensions.Logging;

namespace CourseWorkPIPS
{
    public partial class Static : Form
    {
        private readonly IPassService _passService;
        private readonly IServiceProvider _serviceProvider;

        public Static(IPassService passService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _passService = passService;
            _serviceProvider = serviceProvider;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePickerStart.Value;
            var endDate = dateTimePickerEnd.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания");
                return;
            }

            try
            {
                var passesInPeriod = _passService.GenerateReport(startDate, endDate);

                var typeStats = passesInPeriod
                    .GroupBy(p => p.Type.ToString())
                    .ToDictionary(g => g.Key, g => g.Count());

                var kindStats = passesInPeriod
                    .GroupBy(p => p.Kind.ToString())
                    .ToDictionary(g => g.Key, g => g.Count());
                var statusStats = passesInPeriod
                    .GroupBy(p => p.Status.ToString())
                    .ToDictionary(g => g.Key, g => g.Count());

                ExportToExcel(passesInPeriod, typeStats, kindStats, startDate, endDate, statusStats);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var statick = _serviceProvider.GetRequiredService<PassesForm>();
            statick.Show();
            this.Close();
        }

        private void ExportToExcel(List<Pass> passes,Dictionary<string, int> typeStats, Dictionary<string, int> kindStats, DateTime startDate, DateTime endDate, Dictionary<string, int> statusStats)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Статистика");

                worksheet.Cells["A1"].Value = $"Отчёт по пропускам с {startDate.ToShortDateString()} по {endDate.ToShortDateString()}";
                worksheet.Cells["A1"].Style.Font.Size = 14;
                worksheet.Cells["A1"].Style.Font.Bold = true;

                worksheet.Cells["A3"].Value = "Статистика по типам пропусков";
                worksheet.Cells["A3"].Style.Font.Bold = true;
                worksheet.Cells["A4"].Value = "Тип пропуска";
                worksheet.Cells["A4"].Style.Font.Bold = true;
                worksheet.Cells["B4"].Value = "Количество";
                worksheet.Cells["B4"].Style.Font.Bold = true;
                int summ = 0;
                int row = 5;
                foreach (var item in typeStats)
                {
                    worksheet.Cells[row, 1].Value = item.Key;
                    worksheet.Cells[row, 2].Value = item.Value;
                    summ += item.Value;
                    row++;
                }
                if (typeStats.Any())
                {
                    worksheet.Cells[row, 1].Value = "Всего";
                    worksheet.Cells[row, 2].Value = summ;
                    worksheet.Cells[row, 1, row, 2].Style.Font.Bold = true;
                }
                row += 1 ;
                summ = 0;

                worksheet.Cells[row + 1, 1].Value = "Статистика по видам пропусков";
                worksheet.Cells[row + 1, 1].Style.Font.Bold = true;
                worksheet.Cells[row + 2, 1].Value = "Вид пропуска";
                worksheet.Cells[row + 2, 1].Style.Font.Bold = true;
                worksheet.Cells[row + 2, 2].Value = "Количество";
                worksheet.Cells[row + 2, 2].Style.Font.Bold = true;

                row += 3;
                foreach (var item in kindStats)
                {
                    worksheet.Cells[row, 1].Value = item.Key;
                    worksheet.Cells[row, 2].Value = item.Value;
                    summ += item.Value;
                    row++;
                }
                if (kindStats.Any())
                {
                    worksheet.Cells[row, 1].Value = "Всего";
                    worksheet.Cells[row, 2].Value = summ;
                    worksheet.Cells[row, 1, row, 2].Style.Font.Bold = true;
                }
                row += 1;
                summ = 0;

                worksheet.Cells[row + 1, 1].Value = "Статистика по статусам пропусков";
                worksheet.Cells[row + 1, 1].Style.Font.Bold = true;
                worksheet.Cells[row + 2, 1].Value = "Вид статуса";
                worksheet.Cells[row + 2, 1].Style.Font.Bold = true;
                worksheet.Cells[row + 2, 2].Value = "Количество";
                worksheet.Cells[row + 2, 2].Style.Font.Bold = true;

                row += 3;
                foreach (var item in statusStats)
                {
                    worksheet.Cells[row, 1].Value = item.Key;
                    worksheet.Cells[row, 2].Value = item.Value;
                    summ += item.Value;
                    row++;
                }

                if (statusStats.Any())
                {
                    worksheet.Cells[row, 1].Value = "Всего";
                    worksheet.Cells[row, 2].Value = summ;
                    worksheet.Cells[row, 1, row, 2].Style.Font.Bold = true;
                }
                summ = 0;

                worksheet.Cells.AutoFitColumns();

                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "Excel файл (*.xlsx)|*.xlsx",
                    FileName = $"Отчет_статистики_{startDate:yyyyMMdd}_{endDate:yyyyMMdd}"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Create(dialog.FileName))
                    {
                        package.SaveAs(stream);
                    }
                    MessageBox.Show("Файл сохранён успешно!");
                }
            }
        }
    }
}
