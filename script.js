class Upgrade{
    constructor(name,quantity,cost){
        this.name = name;
        this.quantity = quantity;
        this.cost = cost
    }

    Buy(){
        this.cost*=5;
        this.quantity += 1;
    }
}

let fejlesztesek = [
    new Upgrade("szókincs", 0, 10),  new Upgrade("Íróeszköz", 0, 300), new Upgrade("rímelés", 0, 10000), new Upgrade("modatszerkezet", 0, 10), new Upgrade("Petőfi verseskötet", 0, 10), new Upgrade("Bölcsész diploma", 0, 10), new Upgrade("Alkohol", 0, 10), new Upgrade("Drog", 0, 10), new Upgrade("Kis-Faludy díj", 0, 10)
]