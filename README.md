# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #1 выполнил(а):
- Иванова Ивана Варкравтовна
- РИ000024
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | # | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Структура отчета

- Данные о работе: название работы, фио, группа, выполненные задания.
- Цель работы.
- Задание 1.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 2.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 3.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Выводы.
- ✨Magic ✨

## Цель работы
Ознакомиться с основными операторами зыка Python на примере реализации линейной регрессии.

## Задание 1
### Реализовать совместную работу и передачу данных в связке Python - Google-Sheets – Unity.
Ход работы:
Создал google таблицу и добавил пользователя
Написал python код для записи в гугл таблицу [main.py](https://github.com/VenchasS/DA-in-GameDev-lab2/blob/main/main.py)
Результаты выполнения:
![Screenshot_1](https://user-images.githubusercontent.com/49115035/194918551-c545e14b-6c10-48f6-9be3-1155eb066163.png)
![Screenshot_2](https://user-images.githubusercontent.com/49115035/194918607-99d9abec-7406-4692-ba25-8580593b1f6f.png)

После этого был написанн C# скрипт для юнити чтобы подгрузить данные из гугл таблиц в юнити 
и связать это с звуком в зависимости от данных
Сам C# [скрипт](https://github.com/VenchasS/DA-in-GameDev-lab2/blob/main/NewBehaviourScript.cs)
Результаты выполнения скрипта
![Screenshot_3](https://user-images.githubusercontent.com/49115035/194919147-f8ee87e2-518b-4894-a47e-a995fab3b18e.png)

## Задание 2
### Сделать подгрузку результатов 1 лабы в гугл таблицы.
 Файл 1 лабораторной работы был модифицирован и были сделанны 4 измерения на 1, 10, 100, 1000 итераций после чего данные об `A, B, LOSS` были внесенны в таблицу
 
Python [file](https://github.com/VenchasS/DA-in-GameDev-lab2/blob/main/task2.py)

Резульататы работы:

![Screenshot_4](https://user-images.githubusercontent.com/49115035/194925157-2758eab1-ed23-47a2-b15f-f6ba3a89e4fd.png)
![Screenshot_5](https://user-images.githubusercontent.com/49115035/194925198-7abfe5fa-0706-406c-b2f1-d537e9a0e5ea.png)



## Задание 3
### Какова роль параметра Lr? Ответьте на вопрос, приведите пример выполнения кода, который подтверждает ваш ответ. В качестве эксперимента можете изменить значение параметра.

## Выводы

Абзац умных слов о том, что было сделано и что было узнано.

| Plugin | README |
| ------ | ------ |
| Dropbox | [plugins/dropbox/README.md][PlDb] |
| GitHub | [plugins/github/README.md][PlGh] |
| Google Drive | [plugins/googledrive/README.md][PlGd] |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
| Medium | [plugins/medium/README.md][PlMe] |
| Google Analytics | [plugins/googleanalytics/README.md][PlGa] |

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
