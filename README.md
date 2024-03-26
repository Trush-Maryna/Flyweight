****
# :star2:  `Flyweight`

### :black_nib:	Призначення та застосування шаблону
#### **Легковаговик** — це структурний патерн проектування, що дає змогу вмістити більшу кількість об’єктів у відведеній оперативній пам’яті. Шаблон заощаджує пам’ять, розподіляючи спільний стан об’єктів між собою, замість зберігання однакових даних у кожному об’єкті.
###### Flyweight використовує спільний доступ для ефективної підтримки великої кількості об’єктів. Сучасні **веб-браузери** використовують цю техніку, щоб запобігти завантаженню однакових зображень двічі. 
###### Браузер завантажує всі нові зображення з Інтернету та поміщає їх у внутрішній кеш. Для вже завантажених зображень створюється важливий об’єкт, який має деякі унікальні дані, наприклад положення на сторінці, але все інше посилається на кешований.
#### **Застосовується :**
- коли у програмі використовується **велика кількість об’єктів**;
- через це **високі витрати оперативної пам’яті**;
- коли **більшу частину стану об’єктів можна винести за межі їхніх класів**;
- коли **великі групи об’єктів можна замінити невеликою кількістю об’єктів,** що розділяються, оскільки зовнішній стан винесено.

### Діаграми класів та стану

##### Class Diagram Flyweight:
```mermaid
---
title: Flyweight
---
classDiagram
    Client *-- ConcreteFlyweight
    class ConcreteFlyweight{
        - uniqueState
        - flyweight
        + ConcreteFlyweight(repeatingState, uniqueState)
        + someOperation()
    }
    note for ConcreteFlyweight "this.uniqueState = uniqueState \n this.flyweight = factory.getFlyweight(repeatingState)"
    note for ConcreteFlyweight "flyweight.someOperation(uniqueState)"
    IFlyweight <|.. ConcreteFlyweight
    FlyweightFactory <|-- ConcreteFlyweight
    FlyweightFactory *-- IFlyweight: -cache
    note for FlyweightFactory "if(cache[repeatingState] == null) { \n cache[repeatingState] = new IFlyweight(repeatingState) \n } \n return cache[repeatingState]"
    class IFlyweight{
      <<interface>>
      - repeatingState
      + someOperation(uniqueState)
    }
    class FlyweightFactory{
      - cache:IFlyweight[]
      + getFlyweight(repeatingState)
    }
```
##### State Diagram Flyweight:
```mermaid
---
title: Flyweight
---
stateDiagram
    [*] --> Off
    Off --> Drawing: Start
    Drawing --> Drawing: drawTimer_Tick()
    Drawing --> Off: Stop or stopRequested
    Off --> [*]
```
### Опис основних структурних елементів :
- **FlyweightFactory** керує створенням і повторним використанням flyweight. Фабрика отримує запити, в яких зазначено бажаний стан. Якщо flyweight з таким станом вже створено, фабрика відразу його повертає, а якщо ні — створює новий об’єкт;
- **IFlyweight** інтерфейс, що містить ***внутрішній стан***, який повторювався в багатьох первинних об’єктах;
- **ConcreteFlyweight** містить ***зовнішній стан***, унікальний для кожного об’єкта;
- **Client** обчислює або зберігає concreteFlyweigh.

###### На діаграмі станів зображено конкретну реалізацію шаблону проекту C# Visual Studio для створення малюнку з лініями та овалами.

### Джерела інформації:
##### - [refactoring.guru](https://refactoring.guru/design-patterns/flyweight)
##### - [sourcemaking.com](https://sourcemaking.com/design_patterns/flyweight)
##### - [medium.com](https://medium.com/@rajeshvelmani/lightweight-objects-for-efficient-performance-exploring-the-flyweight-design-pattern-in-java-4595ebfa3165)
##### - [www.digitalocean.com](https://www.digitalocean.com/community/tutorials/flyweight-design-pattern-java)
****
