# c-_control_work-
Это текстовое описание решение задачи

## Задача
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Алгоритм
1. Ввод данных массива
2. Заполнение массива
3. Поиск кол-ва свопадений
4. Формирвоание нового массива
5. Вывод результата


## Описание функций
1. getCountStr(array, searchCountStr):
    * принимает на вход массив **array** и количество элементов в слове **searchCountStr**
    * возвращает количество элементов удовлетворяющих поиску в формате **int**
2. getNewArray(array, searchCountStr):
    * принимает на вход массив **array** и количество элементов в слове **searchCountStr**
    * возвращает массив типа char удовлетворяющих поиску в формате **int**


## Пример работы программы
1. Запустить программу с помощью команды 
```
dotnet run
```
2. Ввести кол-во элементов массива
```
3
```
3. Заполнить массив произвольными символами, через пробел и нажать кнопку **enter**
```
Hello 2 world :-)
```
4. После выполнения программы появится вывод
```
 [“2”, “:-)”]
```