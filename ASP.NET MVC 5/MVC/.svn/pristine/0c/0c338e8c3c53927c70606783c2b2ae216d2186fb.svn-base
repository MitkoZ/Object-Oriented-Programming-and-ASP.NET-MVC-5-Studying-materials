---  BaseSample1 ----
Целта на този проект е да покаже основни понятия в MVC - Controller, View,
както и най-често използвания синтаксис на Razor engine-a.
Има пример как да се предават и четат параметри от URL-a.


---  BaseSample2 ----
Целта на проекта е да демонстрира използването на Session за временно съхранение на обекти.
Това на практика не се ползва така, а с база данни, но за по лесно го правим така,
за да може да трием/редактираме/добавяме обекти.


---  DatabaseRestaurants ----
Конзолно приложение, чиято цел е да покаже базово използване на ADO.NET за четене/промяна/триене на данни.
Има Dataaccess проект в който има папки Repositories и Entities.
Има и DB project.
ConnectionString-a за всички repository-та, е в базовия клас BaseRepository


---  DatabaseRestaurants_DB_Only ----
Този solution съдържа само 1 проект - Sql server database project.
Той служи за да покажем как може да създаваме база данни чрез Visual Studio.


---  EntityFrameworkSample ----
Проект, чиято цел е да се запознаете с Entity Framework и как се използва.
Има проект Repositories, в който има един клас CategoryRepository.cs .
Важно е да се знае, че в Web.Config-a трябва да се добави connection string, който е 
същия като connection string-a в App.Config-a който е генериран при създаване на edmx диаграмата в DataAccess проекта.
Проекта се стартира само в debug и се разглеждат данните от CategoryRepository в CategoryController-a.


---  EntityFrameworkSample_Completed ----
Пример за почти завършен реален сайт.
В него имаме функционалност за администриране на ресторанти и категории - списък, добавяне и изтриване.
Имаме и търсене на ресторанти по име.
Показване на предимството от използване на ViewModel класове.
Направили сме и BaseRepository клас, чиято цел е да спести писане на дублиращ код.


---  FormFieldValidation ----
Проекта няма база данни и демонстрира използване на атрибути за валидация на полета от 
ViewModel класа за регистрация.



---  FormLogin ----
Пример за най-лесен начин за създаване на сесия при логване.
Създаваме клас LoginUserSession за да запазим информация при логването на потребител.
Това се ползва в приложението когато трябва да проверим дали имаме логнат потребител и дали е администратор.
Този пример също няма база данни. 
Има mockup  клас UserRepository, чрез който  се симулира фиктивна връзка с база данни.


---  MVCFilters ----
Стартов проект за MVC филтри.
Този проект е същия като проекта FormLogin. Само сме добавили 2 нови екрана:
Home/About и Admin/Index. Също така само 2 потребителя могат да се логнат - user и admin (с произволни пароли)


---  MVCFilters_Completed ----
Пример за създаване на MVC филтри.
 - Създаване на специфичен (custom) атрибут - CustomAuthorizeAttribute, който дава или забранява достъп до даден Action, според ролята на логнатия потребител.
 - Създаване на специфичен (custom) атрибут - CustomActionFilterAttribute, чиято цел е да измерим времето за което всички action-и се изпълняват.
 - Добавяне на глоблано прихващане на грешки чрез CustomErrorHandlerAttribute.


---  MVCHashPasswordAndCustomValidator ----
The starting project for the example with Hash password and custom validator.
It CAN NOT be compiled! 
You have to fix two errors to make it working.



---  UnitOfWorkSample ----
началния проект за примера. Той е копие на проекта "EntityFrameworkSample_Completed"


---  UnitOfWorkSample_Completed ----
този проект е разширение на проекта EntityFrameworkSample_Completed.
В него са добавени следните функцтионалности:
 - 2 нови таблици - Users и Comments
 - логване на user в системата
 - създаване и редактиране на user
 - добавяне на нов коментар
 - затриване на коментар ако логнатия user е автора на коментара
Тук няма authorize атрибут и всеки може да прави всичко по сайта !


