# тест-кейс 10
Feature: Working With Search Search In Found On The Right Next To The Search

	@lists
	# Работа с поиском Поиск в разделе «Найдено» справа рядом с поиском
	Scenario: Working With Search Search In Found On The Right Next To The Search

	# админ открыл админ панель
		Given the admin opened admin panel

	# админ произвел нажатие на кнопку Списки (возле поиска)
		When the admin clicked on the Lists button next to the search

	# админа перешел на главную страницу админ-панели Коммерсантъ
		And admin went to the main page of the Kommersant admin panel

	# проверка, произвел нажатие на кнопку Списки (возле поиска) и перешел на главную страницу админ-панели Коммерсантъ
		Then check, clicked on the Lists button next to the search and went to the main page of the Kommersant admin panel