class Upgrade {
    constructor(name, quantity, cost, generate, type) {
        this.name = name;
        this.quantity = quantity;
        this.cost = cost;
        this.generate = generate;
        this.type = type;
    }

    Buy() {
        this.cost *= 4;
        this.quantity += 1;
    }
}

class UpgradeDiv {
    constructor(upgrade) {
        this.u = upgrade;
        this.div = document.createElement("div");
        this.div.classList.add("upgrade");

        this.h = document.createElement("h4");
        this.h.textContent = upgrade.name;
        this.div.appendChild(this.h);

        this.costButton = document.createElement("button");
        this.costButton.textContent = upgrade.cost;
        this.costButton.value = upgrade.cost;
        this.div.appendChild(this.costButton);

        this.span = document.createElement("span");
        this.span.textContent = `lvl ${upgrade.quantity}`;
        this.div.appendChild(this.span);

        this.div.addEventListener("click", () => {
            this.BuyD();
        });
    }

    Update() {
        this.costButton.textContent = this.u.cost;
        this.costButton.value = this.u.cost;
        this.span.textContent = `lvl ${this.u.quantity}`;
    }

    BuyD() {
        this.u.Buy();
        this.Update();
        console.log(this.u.cost);
    }
}

function KiirasFrissit(fejlesztesekdiv) {
    const upgradesContainer = document.querySelector(".upgrades");
    upgradesContainer.textContent = "";
    fejlesztesekdiv.forEach(fdiv => {
        upgradesContainer.appendChild(fdiv.div);
        console.log("frissitve");
    });
}

function SzamFrissit(w, v, vk){
    const wspan = document.querySelector(".w")
    const vspan = document.querySelector(".v")
    const vkspan = document.querySelector(".vk")
    wspan.textContent = w;
    vspan.textContent = v;
    vkspan.textContent = vk;
}
let fejlesztesek = [
    new Upgrade("szókincs", 0, 1, 1, "w"),
    new Upgrade("Íróeszköz", 0, 20, 10, "w"),
    new Upgrade("rímelés", 0, 500, 100, "w"),
    new Upgrade("modatszerkezet", 0, 5000, 1000, "w"),
    new Upgrade("Petőfi verseskötet", 0, 50000, 10000, "w"),
    new Upgrade("Bölcsész diploma", 0, 1, 1, "v"),
    new Upgrade("Alkohol", 0, 1000, 100, "v"),
    new Upgrade("Drog", 0, 100000, 10000, "v"),
    new Upgrade("Kis-Faludy díj", 0, 1, 1, "vk"),
    new Upgrade("SzoÓ Virág", 0, 1000000, 0, "vk")
];
let words = 0;
let versek = 0;
let verseskotetek = 0;
let fejlesztesekdiv = fejlesztesek.map(fejlesztes => new UpgradeDiv(fejlesztes));

let Income = setInterval(() => {
    fejlesztesekdiv.forEach(fdiv =>{
        if(fdiv.u.type == "v"){
            versek += fdiv.u.quantity * fdiv.u.generate
        }
        else if(fdiv.u.type == "w"){
            words += fdiv.u.quantity * fdiv.u.generate
        }
        else{
            verseskotetek += fdiv.u.quantity * fdiv.u.generate
        }
    })
    SzamFrissit(words, versek, verseskotetek);
}, 1000)

KiirasFrissit(fejlesztesekdiv);
