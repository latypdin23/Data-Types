# Типы данных

<div align="center">
  <img src="https://media.giphy.com/media/3oKIPnAiaMCws8nOsE/giphy.gif" width="600" height="300"/>
</div>

## Инициализация переменных
1. Явное типизирование
   ```
   int a=5;
   ```
2. Неявное типизирование
   ```
   var name = "Дина";
   var age = 26;
   var isProgrammer = true;

   // Получить тип переменных
   Type nameType = name.GetType();
   Type ageType = age.GetType();

   Console.WriteLine("Тип name: {0}", nameType);
   Console.WriteLine($"Тип age {ageType}");
   Console.WriteLine("Тип isProgrammer {0}", isProgrammer.GetType());
   ```
