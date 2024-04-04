from service import *

COMMAND_ERROR = 'Неверная команда'

instruction = 'Выберите действие: \n' \
            '\t1 - Добавить заметку \n\t2 - Редактировать заметку \n' \
            '\t3 - Удалить заметку \n\t4 - Показать заметку \n' \
            '\t5 - Показать все заметки с выборкой по дате\n\t6 - Очистить все заметки \n' \
            '\t7 - Выход \n'

confid_instruction = 'Вы уверены? \n\t1 - ДА \n\t2 - НЕТ \n'


def start_program():
    print('\n\n\n\n\n\n')
    print(instruction)
    tasks(input("Введите команду --> "))


def confid(command):
    match command:
        case '1':
            clear_notes()
            print('все удалилось')
        case '2':
            print('ну ладно')
        case _:
            print(COMMAND_ERROR)


def tasks(command):
    match command:
        case '1':
            note = creation_note(set_head(), set_body())
            add_note(note)
        case '2':
            change_note(set_id(), set_head(), set_body())
        case '3':
            delete_note(set_id())
        case '4':
            show_note(set_id())
        case '5':
            left = set_date("Введите левую границу даты [dd.mm.yyyy] --> ")
            right = set_date("Введите правую границу даты [dd.mm.yyyy] --> ")
            show_notes(left, right)
        case '6':
            print(confid_instruction)
            confid(input(' --> '))
        case '7':
            save_last_id()
            exit()
        case _:
            print(COMMAND_ERROR)
