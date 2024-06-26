# Лабораторная работа 3
###### Создание системных диграмм последовательностей
#### Прецедент "Вход в игру"
![diagram](/assets/lab3/ВходВИгруЛаб3.png)

##### 1. Войти в игру

| Действие    | Войти в игру             |
|-------------|--------------------------|
| Ссылки      | Прецедент "Вход в игру" |
| Предусловие | Игра не запущена         |
| Постусловие | Игра запущена            |
##### 2. Запросить имя

| Действие    | Запросить имя             |
|-------------|--------------------------|
| Ссылки      | Прецедент "Вход в игру" |
| Предусловие | Игра запущена  |
| Постусловие |  Отображена форма для ввода имени  |
##### 3. Ввести имя

| Действие    | Ввести имя             |
|-------------|--------------------------|
| Ссылки      | Прецедент "Вход в игру" |
| Предусловие | Отображена форма для ввода имени  |
| Постусловие |  Введено имя игрока  |
##### 4. Сохранить имя

| Действие    | Сохранить имя             |
|-------------|--------------------------|
| Ссылки      | Прецедент "Вход в игру" |
| Предусловие | Введено имя игрока  |
| Постусловие |  Имя игрока сохранено  |
##### 5. Выдать стартовый баланс

| Действие    | Выдать стартовый баланс  |
|-------------|--------------------------|
| Ссылки      | Прецедент "Вход в игру" |
| Предусловие | Имя игрока сохранено  |
| Постусловие |  На счет игрока начислен стартовый баланс  |
##### 6. Передать ход игроку

| Действие    | Передать ход игроку  |
|-------------|--------------------------|
| Ссылки      | Прецедент "Вход в игру" |
| Предусловие | На счет игрока начислен стартовый баланс  |
| Постусловие |  Ход передан игроку  |

<br><br>

#### Прецедент "Сделать ставку"

![diagram](/assets/lab3/СделатьСтавкуЛаб3.png)
##### 1. Поставить определённое количество  фишек на ставку

| Действие    | Поставить определённое количество  фишек на ставку |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сделать ставку" |
| Предусловие | Ход передан игроку         |
| Постусловие | Введена сумма и выбран тип ставки  |
##### 2. Проверить не превышает ли ставка баланс игрока

| Действие    | Проверить не превышает ли ставка баланс игрока |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сделать ставку" |
| Предусловие | Введена сумма и выбран тип ставки  |
| Постусловие | Проверена возможность ставки  |
##### 3. Отнять сумму ставки  от баланса  игрока

| Действие    | Отнять сумму ставки  от баланса  игрока |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сделать ставку" |
| Предусловие | Проверена возможность ставки  |
| Постусловие |  Баланс игрока уменьшен на сумму ставки |
##### 4. Зарегистрировать ставку

| Действие    | Зарегистрировать ставку |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сделать ставку" |
| Предусловие | Баланс игрока уменьшен на сумму ставки  |
| Постусловие |  Ставка была сохранена |
##### 5. Предложить сделать следующую ставку

| Действие    | Предложить сделать следующую ставку |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сделать ставку" |
| Предусловие | Ставка была сохранена  |
| Постусловие |  Игроку было предложено сделать следующую ставку |

##### 6. Отказаться  от слеюдующей  ставки

| Действие    | Отказаться  от слеюдующей  ставки |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сделать ставку" |
| Предусловие | Игроку было предложено сделать следующую ставку  |
| Постусловие |  Игрок отказался от ставки |

##### 7. Сгенерировать  выпавший сектор

| Действие    | Сгенерировать  выпавший сектор |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сделать ставку" |
| Предусловие | Игроку было предложено сделать следующую ставку  |
| Постусловие |  Сгенерирован выпавший  сектор |

##### 8. Прибавить выигранное количество фишек к балансу  игрока

| Действие    | Прибавить выигранное количество фишек к балансу  игрока |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сделать ставку" |
| Предусловие | Сгенерирован выпавший  сектор |
| Постусловие | Выбраны выигрышные ставки, сумма их  выигрыша начислена на баланс игрока |

##### 9. Отобразить результат

| Действие    | Отобразить результат |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сделать ставку" |
| Предусловие | Выбраны выигрышные ставки, сумма их  выигрыша начислена на баланс игрока |
| Постусловие | Игроку  отображены реузльтаты ставок и обновлённый баланс |

<br><br>

#### Прецедент "Сохранить игру"
![diagram](/assets/lab3/СохранитьИгруЛаб3.png)

##### 1. Сохранить игру

| Действие    | Сохранить игру |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сохранить игру" |
| Предусловие | Ход передан игроку         |
| Постусловие | Отправлен запрос на сохранение игры  |

##### 2. Создать файл сохранения

| Действие    | Создать файл сохранения |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сохранить игру" |
| Предусловие | Отправлен запрос на сохранение игры |
| Постусловие |  Был создан файл сохранения  |

##### 3. Записать текущий баланс и имя игрока в файл сохранения

| Действие    | Записать текущий баланс и имя игрока в файл сохранения |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сохранить игру" |
| Предусловие | Был создан файл сохранения |
| Постусловие |  В файл сохранения записаны текущие баланс и имя игрока  |

##### 4. Сообщить об успешном сохранении

| Действие    | Сообщить об успешном сохранении |
|-------------|--------------------------|
| Ссылки      | Прецедент "Сохранить игру" |
| Предусловие | В файл сохранения записаны текущие баланс и имя игрока |
| Постусловие | Было отображено сообщение об успешном сохранении  |

<br><br>

#### Прецедент "Загрузить игру"
![diagram](/assets/lab3/ЗагрузитьИгруЛаб3.png)

##### 1. Загрузить игру

| Действие    | Загрузить игру |
|-------------|--------------------------|
| Ссылки      | Прецедент "Загрузить игру" |
| Предусловие | Игра запущена |
| Постусловие | Отправлен запрос на загрузку игры  |

##### 2. Отобразить доступные файлы сохранения

| Действие    | Отобразить доступные файлы сохранения |
|-------------|--------------------------|
| Ссылки      | Прецедент "Загрузить игру" |
| Предусловие | Отправлен запрос на загрузку игры |
| Постусловие | Считаны все файлы сохранения и отображены в виде списка |

##### 3. Выбрать файл сохранения

| Действие    | Выбрать файл сохранения |
|-------------|--------------------------|
| Ссылки      | Прецедент "Загрузить игру" |
| Предусловие | Считаны все файлы сохранения и отображены в виде списка |
| Постусловие | Выбран файл сохранения |

##### 4. Присвоить текущее имя и баланс игрока значениям файла сохранения

| Действие    | Присвоить текущее имя и баланс игрока значениям файла сохранения |
|-------------|--------------------------|
| Ссылки      | Прецедент "Загрузить игру" |
| Предусловие | Выбран файл сохранения |
| Постусловие | Из файла прочитаны значения и присвоены имени и баланса текущего игрока |

##### 5. Отобразить новые имя и баланс игрока

| Действие    | Отобразить новые имя и баланс игрока |
|-------------|--------------------------|
| Ссылки      | Прецедент "Загрузить игру" |
| Предусловие | Из файла прочитаны значения и присвоены имени и баланса текущего игрока |
| Постусловие | Отображены новые имя и баланс игрока |

<br><br>

#### Прецедент "Открыть таблицу лидеров"
![diagram](/assets/lab3/ОткрытьТаблицуЛидеровЛаб3.png)

##### 1. Открыть таблицу лидеров

| Действие    | Открыть таблицу лидеров |
|-------------|--------------------------|
| Ссылки      | Прецедент "Открыть таблицу лидеров" |
| Предусловие | Ход передан игроку |
| Постусловие | Отправлен запрос на отображение таблицы лидеров |

##### 2. Прочитать все файлы сохранения

| Действие    | Прочитать все файлы сохранения |
|-------------|--------------------------|
| Ссылки      | Прецедент "Открыть таблицу лидеров" |
| Предусловие | Отправлен запрос на отображение таблицы лидеров |
| Постусловие | Считаны значения всех файлов сохранения |

##### 3. Выбрать файлы с макисмальным балансом для каждого уникального имени

| Действие    | Выбрать файлы с макисмальным балансом для каждого уникального имени |
|-------------|--------------------------|
| Ссылки      | Прецедент "Открыть таблицу лидеров" |
| Предусловие | Считаны значения всех файлов сохранения |
| Постусловие | Выбраны файлы с уникальными именами и максимальным балансом для каждого имени |

##### 4. Выбрать первые десять по величине баланса

| Действие    | Выбрать первые десять по величине баланса |
|-------------|--------------------------|
| Ссылки      | Прецедент "Открыть таблицу лидеров" |
| Предусловие | Выбраны файлы с уникальными именами и максимальным балансом для каждого имени |
| Постусловие | Среди файлов с уникальными именами и максимальным балансом выбраны первые десять по величине баланса |

##### 5. Сгенерировать таблцу лидеров по данным файлов

| Действие    | Сгенерировать таблцу лидеров по данным файлов |
|-------------|--------------------------|
| Ссылки      | Прецедент "Открыть таблицу лидеров" |
| Предусловие | Среди файлов с уникальными именами и максимальным балансом выбраны первые десять по величине баланса |
| Постусловие | Была создана и заполнена таблица лидеров |

##### 6. Отобразить таблицу лидеров

| Действие    | Отобразить таблицу лидеров |
|-------------|--------------------------|
| Ссылки      | Прецедент "Открыть таблицу лидеров" |
| Предусловие | Была создана и заполнена таблица лидеров |
| Постусловие | Таблица лидеров была отображена |
