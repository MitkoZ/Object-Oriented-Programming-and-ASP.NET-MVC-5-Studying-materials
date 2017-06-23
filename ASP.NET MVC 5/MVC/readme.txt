---  BaseSample1 ----
����� �� ���� ������ � �� ������ ������� ������� � MVC - Controller, View,
����� � ���-����� ����������� ��������� �� Razor engine-a.
��� ������ ��� �� �� �������� � ����� ��������� �� URL-a.


---  BaseSample2 ----
����� �� ������� � �� ����������� ������������ �� Session �� �������� ���������� �� ������.
���� �� �������� �� �� ������ ����, � � ���� �����, �� �� �� ����� �� ������ ����,
�� �� ���� �� �����/�����������/�������� ������.


---  DatabaseRestaurants ----
�������� ����������, ����� ��� � �� ������ ������ ���������� �� ADO.NET �� ������/�������/������ �� �����.
��� Dataaccess ������ � ����� ��� ����� Repositories � Entities.
��� � DB project.
ConnectionString-a �� ������ repository-��, � � ������� ���� BaseRepository


---  DatabaseRestaurants_DB_Only ----
���� solution ������� ���� 1 ������ - Sql server database project.
��� ����� �� �� ������� ��� ���� �� ��������� ���� ����� ���� Visual Studio.


---  EntityFrameworkSample ----
������, ����� ��� � �� �� ���������� � Entity Framework � ��� �� ��������.
��� ������ Repositories, � ����� ��� ���� ���� CategoryRepository.cs .
����� � �� �� ����, �� � Web.Config-a ������ �� �� ������ connection string, ����� � 
����� ���� connection string-a � App.Config-a ����� � ��������� ��� ��������� �� edmx ���������� � DataAccess �������.
������� �� �������� ���� � debug � �� ���������� ������� �� CategoryRepository � CategoryController-a.


---  EntityFrameworkSample_Completed ----
������ �� ����� �������� ������ ����.
� ���� ����� �������������� �� �������������� �� ���������� � ��������� - ������, �������� � ���������.
����� � ������� �� ���������� �� ���.
��������� �� ������������ �� ���������� �� ViewModel �������.
��������� ��� � BaseRepository ����, ����� ��� � �� ������ ������ �� �������� ���.


---  FormFieldValidation ----
������� ���� ���� ����� � ����������� ���������� �� �������� �� ��������� �� ������ �� 
ViewModel ����� �� �����������.



---  FormLogin ----
������ �� ���-����� ����� �� ��������� �� ����� ��� �������.
��������� ���� LoginUserSession �� �� ������� ���������� ��� ��������� �� ����������.
���� �� ������ � ������������ ������ ������ �� �������� ���� ����� ������ ���������� � ���� � �������������.
���� ������ ���� ���� ���� �����. 
��� mockup  ���� UserRepository, ���� �����  �� �������� �������� ������ � ���� �����.


---  MVCFilters ----
������� ������ �� MVC ������.
���� ������ � ����� ���� ������� FormLogin. ���� ��� �������� 2 ���� ������:
Home/About � Admin/Index. ���� ���� ���� 2 ����������� ����� �� �� ������ - user � admin (� ���������� ������)


---  MVCFilters_Completed ----
������ �� ��������� �� MVC ������.
 - ��������� �� ���������� (custom) ������� - CustomAuthorizeAttribute, ����� ���� ��� ��������� ������ �� ����� Action, ������ ������ �� �������� ����������.
 - ��������� �� ���������� (custom) ������� - CustomActionFilterAttribute, ����� ��� � �� ������� ������� �� ����� ������ action-� �� ����������.
 - �������� �� �������� ���������� �� ������ ���� CustomErrorHandlerAttribute.


---  MVCHashPasswordAndCustomValidator ----
The starting project for the example with Hash password and custom validator.
It CAN NOT be compiled! 
You have to fix two errors to make it working.



---  UnitOfWorkSample ----
�������� ������ �� �������. ��� � ����� �� ������� "EntityFrameworkSample_Completed"


---  UnitOfWorkSample_Completed ----
���� ������ � ���������� �� ������� EntityFrameworkSample_Completed.
� ���� �� �������� �������� ����������������:
 - 2 ���� ������� - Users � Comments
 - ������� �� user � ���������
 - ��������� � ����������� �� user
 - �������� �� ��� ��������
 - ��������� �� �������� ��� �������� user � ������ �� ���������
��� ���� authorize ������� � ����� ���� �� ����� ������ �� ����� !


