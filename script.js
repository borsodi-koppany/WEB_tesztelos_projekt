class Upgrade{
    constructor(name,quantity,cost){
        this.name = name;
        this.quantity = quantity;
        this.cost = cost
    }

    Buy(){
        this.cost*=4;
        this.quantity += 1;
    }
}

let fejlesztesek = [
    new Upgrade("szókincs", 0, 1),  new Upgrade("Íróeszköz", 0, 20), new Upgrade("rímelés", 0, 500), new Upgrade("modatszerkezet", 0, 5000), new Upgrade("Petőfi verseskötet", 0, 50000), new Upgrade("Bölcsész diploma", 0, 1000000), new Upgrade("Alkohol", 0, 5000000), new Upgrade("Drog", 0, 10), new Upgrade("Kis-Faludy díj", 0, 2000000)
]

fejlesztesek.forEach(fejlesztes => {
    let d = document.createElement("div");
    d.classList.add("upgrade");
    let h = document.createElement("h4")
    h.textContent = fejlesztes.name;
    let span = document.createElement("span")
    span.textContent = fejlesztes.quantity
    let cost = document.createElement("button")
    cost.value = fejlesztes.cost;
    d.appendChild(h);
    d.appendChild(span);
    d.appendChild(cost);
    document.querySelector(".upgrades").appendChild(d)
})