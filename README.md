# Билет №7
## Теоретический вопрос
<b> TDD (Test Driven Development) </b> - процесс разработки через тестирование — это методология разработки программного обеспечения, которая основывается на повторении коротких циклов разработки: изначально пишется тест, покрывающий желаемое изменение, затем пишется программный код, который реализует желаемое поведение системы и позволит пройти написанный тест, а затем проводится рефакторинг написанного кода с постоянной проверкой прохождения всех тестов. <br>
TDD хорошо подходит для юнит-тестирования, т.е. для проверки работы отдельных модулей самих по себе. Проверяет работу функций. <br>
  Циклы разработки в нем называются Красный, Зеленый, Рефакторинг (Red, Green, Refactor).
 * Красный - что мы хотим сделать.
 * Зеленый - как пройти тесты.
 * Рефакторинг - как улучшить существующую реализацию.
  
![image](https://user-images.githubusercontent.com/90379312/177027080-a79f2938-aed5-4069-9731-5f8aa86251aa.png)
![image](https://user-images.githubusercontent.com/90379312/177027121-4b210860-8c14-4224-84b1-5da612b59ecf.png)


# Тестовые данные
Использованные для проверки пароли: 
* PassEigh
* Pass
* PassMoreThenTwentySymbols
* LessThen20Symbols
* Pass4asDigs
* Passwithchars
* ThisPassHasSpec%^&
* nospecsymbols
* HasUpperCase
* hasonlylower
* ThisPassCanBeTake8_
* ThisPassCanеBeTake

# Скриншоты
![image](https://user-images.githubusercontent.com/90379312/177026245-53675f83-2352-4bd9-b08a-ebfc29e9313f.png)
![image](https://user-images.githubusercontent.com/90379312/177026267-7ff6d7dd-c775-4095-a96a-9bfd68855c85.png)



# Источники 
[testing-template.docx](https://docs.google.com/document/d/1HOLKqPUAQFTGmtaQGacwKFFMZiCr6q8s/edit#heading=h.gjdgxs) - шаблон тестового сценария <br>
[4Создание библиотеки классов.mp4](https://drive.google.com/file/d/1tV1DiGGJzMwXtKUpl05LZD5CXcK4Pk6V/view?usp=sharing) - инструкция по созданию библиотеки классов<br>
[Модульное тестирование (Unit-tests)](https://nationalteam.worldskills.ru/skills/modulnoe-testirovanie-unit-tests/) - инструкция по созданию модуля<br>
https://github.com/kolei/yotc/blob/master/articles/demo_session3.md - пример выполнения задания<br>
