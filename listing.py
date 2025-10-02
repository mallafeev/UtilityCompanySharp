import os
from pathlib import Path

# ⚙️ Настройки
PROJECT_ROOT = input("Введите путь к корню проекта: ").strip()
OUTPUT_FILE = "listing.txt"
EXCLUDE_DIRS = {"bin", "obj", "__pycache__"}
EXCLUDE_FILES = {".dll", ".exe", ".pdb", ".ilk", ".user", ".cache"}
INCLUDE_EXTENSIONS = {".cs", ".py", ".json", ".razor", ".sql", ".xml", ".md", ".txt", ".ini", ".csproj", ".sln"}

# 📝 Функция для проверки, нужно ли исключить файл или папку
def should_exclude(path, name, is_dir=False):
    if is_dir and name in EXCLUDE_DIRS:
        return True
    if not is_dir and any(name.endswith(ext) for ext in EXCLUDE_FILES):
        return True
    return False

# 📁 Функция для рекурсивного обхода файлов
def collect_files(root_path):
    files_to_include = []
    for dirpath, dirnames, filenames in os.walk(root_path):
        # Удаляем папки, которые нужно исключить
        dirnames[:] = [d for d in dirnames if not should_exclude(dirpath, d, is_dir=True)]
        for file in filenames:
            if any(file.endswith(ext) for ext in INCLUDE_EXTENSIONS):
                full_path = Path(dirpath) / file
                files_to_include.append(full_path)
    return files_to_include

# 📄 Функция для записи листинга в файл
def write_listing_to_file(files, output_file):
    with open(output_file, "w", encoding="utf-8") as out:
        for file_path in files:
            relative_path = file_path.relative_to(PROJECT_ROOT)
            try:
                with open(file_path, "r", encoding="utf-8") as f:
                    content = f.read()
                out.write(f"// File: {relative_path}\n")
                out.write(content)
                out.write("\n\n")
                print(f"Добавлен файл: {relative_path}")
            except Exception as e:
                print(f"[!] Ошибка чтения файла: {relative_path} — {str(e)}")

# 🔁 Основная функция
if __name__ == "__main__":
    project_path = Path(PROJECT_ROOT)
    if not project_path.exists():
        print("[Ошибка] Указанный путь не существует.")
        exit(1)

    files = collect_files(project_path)
    if not files:
        print("[Ошибка] Не найдено подходящих файлов для включения.")
        exit(1)

    write_listing_to_file(files, OUTPUT_FILE)
    print(f"\n✅ Листинг успешно сохранён в {OUTPUT_FILE}")