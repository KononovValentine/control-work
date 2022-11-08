# README

## Оформленное текстовое описание решения

### **Полезное:**

* [Ссылка на задание](https://gb.ru/lessons/276634/homework)
* [Ссылка на репозиторий](https://github.com/KononovValentine/control-work)
* [Ссылка на блоксхему в формате drawio (в архиве 7z)](https://disk.yandex.ru/d/rUSKPxoylGBVNw)
* Скриншот задания

![Скриншот задания!](https://sun9-east.userapi.com/sun9-36/s/v1/ig2/4NvIj4mpZvxtufC86fm98BCY6bGf1a8I-wZ7o6pAKY_RZwqfkPiGXt8Z_RKspd2VV8VhjHGWo8fO1LEfkdj5UWSR.jpg?size=1233x715&quality=96&type=album)

### **Скриншоты алгоритмов**

1. ReadDataString
![Алгоритм ReadDataString](https://sun9-east.userapi.com/sun9-17/s/v1/ig2/I3GQT-BEfBlwuUuGlCyrlR1-Riz2et6qESkfQTM3yvRRQurxy6cJgliitDJZk_MAuYqf7dsnob1TuaQ__iTE72Pq.jpg?size=827x642&quality=96&type=album)
2. ReadDataNumber
![Алгоритм ReadDataNumber](https://sun9-east.userapi.com/sun9-17/s/v1/ig2/BMW3EctMmP_QEROHxbZFceN0Ufj4nyE2AsS0Ow18L-iI4Nz6RmMhqA7f2Is732S1dSbyEMPJQGau53m9NhV0CNDA.jpg?size=828x720&quality=96&type=album)
3. SortArrayMaxCountSymbols
![Алгоритм SortArrayMaxCountSymbols](https://sun7.userapi.com/sun7-8/s/v1/ig2/EDI6JjwZoRr1HnX4ktgbqzyriwnMM9h9wcPeVvPRCjhS4fS0GOvjp3l3a-jir3GyF8e9jOu6uD1VmWuXN2R1KqrJ.jpg?size=828x881&quality=96&type=album)
4. CreateFinalArray
![Алгоритм CreateFinalArray](https://sun9-east.userapi.com/sun9-44/s/v1/ig2/ZZ1QF-RmdvQxzjV8D81wzhZJTLJ-RpYvhkOgbhrJ1POMjaSengVuVhr48PR8aGGa_K6dXjZYq1GYEyAetV9hroqM.jpg?size=824x882&quality=96&type=album)
5. PrintArray
![Алгоритм PrintArray](https://sun9-west.userapi.com/sun9-1/s/v1/ig2/B9Hu7LK3GO1QaotwjkMl7n7pvggjBFR2-ITqpqgWntvBoJlBIgMk3o-mzRoh5HarVVVPwqPcn_0GEUfoVK-Im08r.jpg?size=824x717&quality=96&type=album)

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