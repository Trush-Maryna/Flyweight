****
# :star2:  `Flyweight`

### :black_nib:	����������� �� ������������ �������
#### **������������** � �� ����������� ������ ������������, �� �� ����� ������� ����� ������� �ᒺ��� � �������� ���������� �����. ������ �������� ������, ����������� ������� ���� �ᒺ��� �� �����, ������ ��������� ��������� ����� � ������� �ᒺ��.
###### Flyweight ����������� ������� ������ ��� ��������� �������� ������ ������� �ᒺ���. ������ **���-��������** �������������� �� ������, ��� �������� ������������ ��������� ��������� ����. 
###### ������� ��������� �� ��� ���������� � ��������� �� ����� �� � �������� ���. ��� ��� ������������ ��������� ����������� �������� �ᒺ��, ���� �� ���� ������� ���, ��������� ��������� �� �������, ��� ��� ���� ���������� �� ���������.
#### **������������� :**
- ���� � ������� ��������������� **������ ������� �ᒺ���**;
- ����� �� **����� ������� ���������� �����**;
- ���� **����� ������� ����� �ᒺ��� ����� ������� �� ��� ���� �����**;
- ���� **����� ����� �ᒺ��� ����� ������� ��������� ������� �ᒺ���,** �� �����������, ������� ������� ���� ��������.

### ĳ������ ����� �� �����

##### Class Diagram Flyweight:
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
##### State Diagram Flyweight:
---
title: Flyweight
---
stateDiagram
    [*] --> Off
    Off --> Drawing: Start
    Drawing --> Drawing: drawTimer_Tick()
    Drawing --> Off: Stop or stopRequested

### ���� �������� ����������� �������� :
- **FlyweightFactory** ���� ���������� � ��������� ������������� flyweight. ������� ������ ������, � ���� ��������� ������� ����. ���� flyweight � ����� ������ ��� ��������, ������� ������ ���� �������, � ���� � � ������� ����� �ᒺ��;
- **IFlyweight** ���������, �� ������ ***�������� ����***, ���� ������������ � �������� ��������� �ᒺ����;
- **ConcreteFlyweight** ������ ***������� ����***, ��������� ��� ������� �ᒺ���;
- **Client** �������� ��� ������ concreteFlyweigh.

###### �� ������ ����� ��������� �������� ����� �� ������� ��� ��������� ������� � ����� �� �������. 
#### ��������� IShape �� �������� ��������� Line �� Oval. ���� Oval �� �������� ���������� ���������, ����������� ����� ������� �������� �� �, ��� �� Line �� �� ����� ��������� ����������.

### ������� ����������:
##### - [refactoring.guru](https://refactoring.guru/design-patterns/flyweight)
##### - [sourcemaking.com](https://sourcemaking.com/design_patterns/flyweight)
##### - [medium.com](https://medium.com/@rajeshvelmani/lightweight-objects-for-efficient-performance-exploring-the-flyweight-design-pattern-in-java-4595ebfa3165)
##### - [www.digitalocean.com](https://www.digitalocean.com/community/tutorials/flyweight-design-pattern-java)
****