  El proyecto comenzó como un diagrama en el que se pretendía realizar un pequeño acercamiento a C# implementando una pequeña jerarquía en la que creamos un personaje y le añadimos equipamiento:  

![image](https://github.com/user-attachments/assets/a709c28d-9d7e-419b-8937-6b63a1b29de1)

  El programa requería poder equipar un objeto y que este manifestara una mascota. Se ha optado por ligar la mascota (FireSpirit) a la gran espada. Esto se ha realizado mediante una interfaz IPet: 
  https://github.com/aaracan246/PrimerasPruebasCsharp/blob/3de65d864fcd54b8f757259ebfb4de8ee25198e7/EjercicioEsquema/interfaces/IPet.cs#L3

  Esta interfaz cuenta con dos métodos Attack() y Defend(), que podrán ser usados por la pet una vez sea invocada. La función de invocación está dentro de la Greatsword: https://github.com/aaracan246/PrimerasPruebasCsharp/blob/3de65d864fcd54b8f757259ebfb4de8ee25198e7/EjercicioEsquema/classes/weapon/Greatsword.cs#L24    

  Como se requería de un test, también se ha testeado la función Apply(Character) de Shield para comprobar si el inventario estaba recibiendo el item o no:
  https://github.com/aaracan246/PrimerasPruebasCsharp/blob/eca7e293316db4d5b4f1a7b15051cea1d92b7578/EjercicioEsquema.Tests/classes/armor/ShieldTest.cs#L14
