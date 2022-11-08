# README

## Оформленное текстовое описание решения

### **Полезное:**

* [Ссылка на задание](https://gb.ru/lessons/276634/homework)
* [Ссылка на репозиторий](https://github.com/KononovValentine/control-work)
* [Ссылка на блоксхему в формате drawio (в архиве 7z)](https://disk.yandex.ru/d/rUSKPxoylGBVNw)
* Скриншот задания

![Скриншот задания!](https://sun9-east.userapi.com/sun9-36/s/v1/ig2/4NvIj4mpZvxtufC86fm98BCY6bGf1a8I-wZ7o6pAKY_RZwqfkPiGXt8Z_RKspd2VV8VhjHGWo8fO1LEfkdj5UWSR.jpg?size=1233x715&quality=96&type=album)

### **Скриншоты алгоритмов**

### **Описание работы программы**

При запуске программы происходит инициализация переменных с выводимым в консоль текстом и вывод в консоль сообщения с просьбой ввести массив строк. Затем программа ждет от пользователя ввода и разбивает введенный текст на массив строк с делением элементов через запятую.
```
string insertStringText = "Введите массив строк через запятую без пробелов = ";
string insertNumberText = "Введите количество символов в подстроке = ";

string[] stringArray = ReadDataString(insertStringText).Split(',');
```
После этого происходит подобная процедура с запросом максимального числа символов в подстроке.
```
int substringNumber = ReadDataNumber(insertNumberText);
```
Следующим шагом происходит вызов функции, возвращающей ***кортеж*** (набор переменных), который состоит из строкового массива и числа итераций, в которых происходила запись данных в новый архив.
```
var tuple = SortArrayMaxCountSymbols(stringArray, substringNumber).ToTuple();
```
Далее, чтобы избавиться от лишних ***NULL***-элементов получившегося массива вызываем функцию, которая принимает массив строк и размер необходимого массива, а на выход возвращает новый массив без пустых ячеек.
```
string[] finalArray = CreateFinalArray(tuple.Item1, tuple.Item2);
```
В конце получившийся массив выводится в консоль.
```
PrintArray(finalArray);
```