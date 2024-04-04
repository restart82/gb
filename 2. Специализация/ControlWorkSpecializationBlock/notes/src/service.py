import datetime
import json
import traceback


def check_last_id():
    with open(LAST_ID, 'r', encoding='utf8') as f:
        number = f.read(1)
    f.close()
    return int(number)


MY_NOTE = 'note.json'
LAST_ID = 'last_id.txt'
ID = check_last_id()
KEY_CONFIG = 'Note #'
OUT_OF_BOUNDS = 'заметка не найдена'
FILE_NOT_FOUND = 'файл не найден'

f_date = lambda: f'{datetime.datetime.now():%d.%m.%Y}'
f_time = lambda: f'{datetime.datetime.now():%H:%M:%S}'


# Заметка должна
# содержать идентификатор, заголовок, тело заметки и дату/время создания или
# последнего изменения заметки.
class Note:
    'Класс-сущность для полей заметки'

    def __init__(self, id, head, body, creation_date, creation_time):
        self.id = id
        self.head = head
        self.body = body
        self.creation_date = creation_date
        self.creation_time = creation_time

    def get_id(self):
        return self.id

    def get_head(self):
        return self.head

    def get_body(self):
        return self.body

    def get_creation_date(self):
        return self.creation_date

    def get_creation_time(self):
        return self.creation_time


# Реализовать консольное приложение заметки, с сохранением, чтением,
# добавлением, редактированием и удалением заметок
def creation_note(head, body):
    global ID
    ID += 1
    new_note = Note(ID, head, body, f_date(), f_time())
    return new_note


def add_note(savable_note, json_file=MY_NOTE):
    json_body = {
        'head': savable_note.head,
        'body': savable_note.body,
        'date': savable_note.creation_date,
        'time': savable_note.creation_time
    }
    number = str(savable_note.id)
    to_json = {KEY_CONFIG + number: json_body}
    try:
        with open(json_file, 'r', encoding='utf8') as f:
            data = json.load(f)
            data.update(to_json)
            with open(json_file, 'w', encoding='utf8') as f_out:
                json.dump(data, f_out, indent=2)
            f_out.close()
    except FileNotFoundError:
        with open(json_file, 'a', encoding='utf8') as f:
            json.dump(to_json, f, indent=2)
        f.close()


def change_note(id, head, body, json_file=MY_NOTE):
    try:
        with open(json_file, 'r', encoding='utf8') as f:
            data = json.load(f)
        f.close()
    except FileNotFoundError:
        print(FILE_NOT_FOUND)
        return

    try:
        key = KEY_CONFIG + str(id)
        if key not in data.keys():
            raise LookupError()
    except LookupError:
        print(OUT_OF_BOUNDS)
    else:
        data[key] = {
            'head': head,
            'body': body,
            'date': f_date(),
            'time': f_time()
        }
        with open(json_file, 'w', encoding='utf8') as f_out:
            json.dump(data, f_out, indent=2)
        f_out.close()


def delete_note(id, json_file=MY_NOTE):
    try:
        with open(json_file, 'r', encoding='utf8') as f:
            data = json.load(f)
        f.close()
    except FileNotFoundError:
        print(FILE_NOT_FOUND)
        return
    try:
        key = KEY_CONFIG + str(id)
        if key not in data.keys():
            raise LookupError()
    except LookupError:
        print(OUT_OF_BOUNDS)
    else:
        del data[key]
        with open(json_file, 'w', encoding='utf8') as f_out:
            json.dump(data, f_out, indent=2)
        f_out.close()


def show_note(id, json_file=MY_NOTE):
    try:
        with open(json_file, 'r', encoding='utf8') as f:
            data = json.load(f)
        f.close()
    except FileNotFoundError:
        print(FILE_NOT_FOUND)
        return
    try:
        key = KEY_CONFIG + str(id)
        if key not in data.keys():
            raise LookupError()
    except LookupError:
        print(OUT_OF_BOUNDS)
    else:
        print_note(data, key)


def show_notes(left_date, right_date, json_file=MY_NOTE):
    try:
        left_date = left_date.split(".")
        left_date = datetime.datetime(int(left_date[2]), int(left_date[1]), int(left_date[0]))
        right_date = right_date.split(".")
        right_date = datetime.datetime(int(right_date[2]), int(right_date[1]), int(right_date[0]))
    except ValueError:
        print("Некорректная дата")
        print(traceback.format_exc())
        return
    except IndexError:
        print("Некорректная дата")
        return
    try:
        with open(json_file, 'r', encoding='utf8') as f:
            data = json.load(f)
        f.close()
    except FileNotFoundError:
        print(FILE_NOT_FOUND)
        return
    for key in data.keys():
        data_date = data[key]["date"]
        data_date = data_date.split(".")
        data_date = datetime.datetime(int(data_date[2]), int(data_date[1]), int(data_date[0]))
        if left_date <= data_date <= right_date:
            print_note(data, key)


def clear_notes(json_file=MY_NOTE):
    try:
        with open(json_file, 'r', encoding='utf8') as f:
            data = json.load(f)
        f.close()
    except FileNotFoundError:
        print(FILE_NOT_FOUND)
        return
    data.clear()
    with open(json_file, 'w', encoding='utf8') as f_out:
        json.dump(data, f_out, indent=2)
    f_out.close()


def print_note(data, key):
    print(key + ':')
    print('\tЗаголовок: ' + data[key]['head'])
    print('\tЗаписка: ' + data[key]['body'])
    print('\tДата создания / изменения: ' + data[key]['date'])
    print('\tВремя создания / изменения: ' + data[key]['time'])


def save_last_id():
    global ID
    with open(LAST_ID, 'w', encoding='utf8') as f:
        f.write(str(ID))
    f.close()


def set_id():
    number = input('Введите ID:\t\t')
    if number.isdigit():
        return number
    else:
        print('Должны быть цифры')
        return set_id()


def set_head():
    return input('Введите заголовок заметки:\t')


def set_body():
    return input('Введите заметку:\t\t')


def set_date(message):
    return input(message)
