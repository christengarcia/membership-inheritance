# Membership Inheritance

A program for a fitness club that has two types of membership - VIP and Normal.

It uses Inheritance from a *Parent class* that has the following contents:

#### Fields
```C#
protected int annualFee
private string name
private int memberID
private int memberSince
```

#### Methods
```C#
public override string ToString()
```

#### Constructors
```C#
public Member()
public Member(string pName, int pMemberID, int pMemberSince)
```
-------------------------------------------------------------

The *Child class* for `NormalMember` has the follwing contents:

#### Fields
*Inherited from parent class:*
protected int annualFee

#### Methods
*Inherited from parent class:*
```C#
public override string ToString()
```

*Declared in child class:*
```C#
public void CalculateAnnualFee()
```

#### Constructors
```C#
public NormalMember()
public NormalMember(string remarks, string name, int memberID, int memberSince)
```
----------------------------------------------------------------

The *Child class* for `VIPMember` has the following contents:

#### Fields
Inherited from parent class:
```C#
protected int annualFee
```

#### Methods
*Inherited from parent class:*
```C#
public override string ToString()
```

*Declared in child class:*
```C#
public void CalculateAnnualFee()
```

#### Constructors
```C#
public VIPMember(string name, int memberID, int memberSince)
```


