# Задания по использованию Windows API в .NET

Этот проект содержит 4 задания по использованию унаследованного кода (Windows API) в .NET приложениях.

## Структура проекта

### Задание 1: MessageBox
**Проект:** `Task1_MessageBox`

Приложение использует функцию `MessageBox` из Windows API для отображения информации о пользователе в нескольких окнах сообщений.

**Запуск:**
```bash
cd Task1_MessageBox
dotnet run
```

### Задание 2: FindWindow и SendMessage
**Проекты:** 
- `Task2_WindowControl` - приложение для управления окнами
- `Task2_TargetWindow` - целевое окно для управления

Приложение использует функции `FindWindow` и `SendMessage` из Windows API для поиска окна и отправки ему сообщений:
- Изменение заголовка окна
- Закрытие окна
- Минимизация окна (дополнительный вариант)

**Запуск:**
1. Сначала запустите `Task2_TargetWindow`:
```bash
cd Task2_TargetWindow
dotnet run
```

2. Затем запустите `Task2_WindowControl`:
```bash
cd Task2_WindowControl
dotnet run
```

В приложении управления введите заголовок окна "TargetWindowApp" и нажмите "Найти окно".

### Задание 3: Beep и MessageBeep
**Проект:** `Task3_Beep`

Приложение использует функции `Beep` и `MessageBeep` из Windows API для генерации звуковых сигналов через определенные промежутки времени.

**Запуск:**
```bash
cd Task3_Beep
dotnet run
```

### Задание 4: Изменение стилей элементов управления
**Проекты:**
- `Task4_TargetApp` - приложение с элементами управления
- `Task4_StyleChanger` - приложение для изменения стилей

Первое приложение содержит различные элементы управления (TextBox, Button, Label, CheckBox, RadioButton, ComboBox). Второе приложение использует Windows API для изменения стилей этих элементов.

**Запуск:**
1. Сначала запустите `Task4_TargetApp`:
```bash
cd Task4_TargetApp
dotnet run
```

2. Затем запустите `Task4_StyleChanger`:
```bash
cd Task4_StyleChanger
dotnet run
```

В приложении изменения стилей нажмите "Найти TargetApp" и используйте кнопки для изменения стилей элементов управления.

## Требования

- .NET 6.0 или выше
- Windows (для работы Windows API)
- Visual Studio 2022 или VS Code с расширением C#

## Технологии

- C#
- Windows Forms
- P/Invoke для вызова Windows API
- .NET 6.0

