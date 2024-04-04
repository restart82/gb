####################################################### Разбор ДЗ
# 1. Создать каталоги students и mentors в домашней директории, а в них — текстовые файлы students_list.txt и mentors_list.txt соответственно.
# создадим нужные папки
mkdir students
mkdir mentors

# 2. заполнить файлы данными
# заполним студентов
nano students_list.txt

Иван Диванов
Наталья Братан
Акиф Мамед Гадим Оглы

# заполним наставников
nano mentors_list.txt

Cтивен Хокинг
Альберт Эйнштейн


#	3. Переместите файл mentors_list.txt в папку students.
mv mentors/mentors_list.txt students/
 

# 4. Удалите папку mentors.
# способ из прошлого урока
rm -r mentors/

# безопасный способ удаления только пустого каталога
rmdir mentors/


# 5. Переименуйте папку students в students_and_mentors.
mv students students_and_mentors
 

# 6. Удалите папку students_mentors вместе с содержимым.
# правильное удаление (с ключом –r)
rm -r students_mentors


# 7*.	Создать файл file1 и наполнить его произвольным содержимым. Скопировать его в file2. Создать символическую ссылку file3 на file1. Создать жёсткую ссылку file4 на file1. Посмотреть, какие inode у файлов. Удалить file1. Что стало с остальными созданными файлами? Попробовать вывести их на экран.
# Создать файл file1 и наполнить его произвольным содержимым.
echo 'some content...' > file1

# Скопировать его в file2. 
cp file1 file2

# Создать символическую ссылку file3 на file1. 
ln -s file1 file3

# Создать жёсткую ссылку file4 на file1. 
ln file1 file4

# Посмотреть, какие inode у файлов. 
ls -li

# Удалить file1. Что стало с остальными созданными файлами? 
rm file1
ls -li
	Жёсткая ссылка продолжает корректно работать. 
	Символическая ссылка сломалась.

# Попробовать вывести их на экран.
cat file4
	Видим содержимое файла
cat file3
	Нет такого файла или каталога


# 8*.	Дать созданным файлам другие, произвольные имена. Создать новую символическую ссылку. Переместить ссылки в другую директорию.
# Дать созданным файлам другие, произвольные имена. 
mv file1 file11
mv file2 file22

# Создать новую символическую ссылку. 
ln -s file11 file11_symlink
ln -s $(pwd)/file22 file22_symlink

# Переместить ссылки в другую директорию.
mkdir links
mv *_symlink links/
