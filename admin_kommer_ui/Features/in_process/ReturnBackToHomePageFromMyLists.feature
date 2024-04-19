# тест-кейс 9
Feature: Return Back To Home Page From My Lists

	@lists
	# Вернуться на главную страницу из моих списков
	Scenario: Return Back To Home Page From My Lists

	# админ открыл админ панель
		Given admin opened admin panel

	# админ произвел нажатие на иконку дома
		When the admin clicked on the home icon

	# админа перевело на главную страницу админ-панели Коммерсантъ
		And admin was transferred to the main page of the Kommersant admin panel

	# проверка, при нажатие на иконку стрелки дома, переводит на главную страницу админ панели коммерсат
		Then check, when you click on the home arrow icon, it takes you to the main page of the Kommersat admin panel