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
        this.generate *= 2;
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
        this.costButton.textContent = upgrade.cost + "";

         if(this.u.type == "v"){
            let i = document.createElement("i");
            i.classList.add("fa-solid")
            i.classList.add("fa-music")
            this.icon = i;
            this.costButton.append(this.icon)

        }
        else if(this.u.type == "w"){
            let i = document.createElement("i");
            i.classList.add("fa-solid")
            i.classList.add("fa-w")
            this.icon = i;
            this.costButton.append(this.icon)

        }
        else{
            let i = document.createElement("i");
            i.classList.add("fa-solid")
            i.classList.add("fa-book")
            this.icon = i;
            this.costButton.append(this.icon)
        }
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
        this.costButton.append(this.icon)
        this.costButton.value = this.u.cost;
        this.span.textContent = `lvl ${this.u.quantity}`;
    }

    BuyD() {
        if(words >= this.u.cost){
            if(this.u.quantity == 0){
                if(this.u.name == "Bölcsész diploma"){
                        
                        
                    
                    let d = document.createElement("div")
                    d.classList.add("diploma")
                    document.querySelector(".display").append(d);
                   
                }
               else if(this.u.name == "Alkohol"){
                    let d = document.createElement("div")
                    d.classList.add("alkohol")
                    document.querySelector(".display").append(d);
                   
                }
               else if(this.u.name == "Drog"){
                    let d = document.createElement("div")
                    d.classList.add("drog")
                    document.querySelector(".display").append(d);
                   
                }
                if(this.u.name == "Íróeszköz"){
                    document.querySelector(".kolto").classList.add("koltofejlesztve");
                    console.log("jo")
                }
                if(this.u.name == "Íróeszköz"){
                    document.querySelector(".kolto").classList.add("koltofejlesztve");
                    
                }
               else if(this.u.name == "Szókincs"){
                    let d = document.createElement("div")
                    d.classList.add("szokincs")
                    document.querySelector(".display").append(d);
                   
                }
               else if(this.u.name == "Rímelés"){
                    let d = document.createElement("div")
                    d.classList.add("rimeles")
                    document.querySelector(".display").append(d);
                   
                }
               else if(this.u.name == "Mondatszerkezet"){
                    let d = document.createElement("div")
                    d.classList.add("mondatszerk")
                    document.querySelector(".display").append(d);
                   
                }
               else if(this.u.name == "Petőfi verseskötet"){
                    let d = document.createElement("div")
                    d.classList.add("petofi")
                    document.querySelector(".display").append(d);
                   
                }
                if(this.u.name == "Kis-Faludy díj"){
                        
                        
                    
                    let d = document.createElement("div")
                    d.classList.add("kisfaludy")
                    document.querySelector(".display").append(d);
                   
                }
               else if(this.u.name == "SzoÓ Virág"){
                    let d = document.createElement("div")
                    d.classList.add("szoovirag")
                    document.querySelector(".display").append(d);
                   
                }
            }
            words -= this.u.cost;
                this.u.Buy();
                SzamFrissit(words, versek, verseskotetek)
        }
        this.Update();
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
    new Upgrade("Íróeszköz", 0, 1, 1, "w"),
    new Upgrade("Szókincs", 0, 20, 10, "w"),
    new Upgrade("Rímelés", 0, 500, 100, "w"),
    new Upgrade("Mondatszerkezet", 0, 5000, 1000, "w"),
    new Upgrade("Petőfi verseskötet", 0, 50000, 10000, "w"),
    new Upgrade("Bölcsész diploma", 0, 200000, 100000, "w"),
    new Upgrade("Alkohol", 0, 1000000, 300000, "w"),
    new Upgrade("Drog", 0, 100000000, 10000000, "w"),
    new Upgrade("Kis-Faludy díj", 0, 1000000000, 100000000, "w"),
    new Upgrade("SzoÓ Virág", 0, 10000000000000, 0, "w")
];

var words = 1;
var versek = 0;
var verseskotetek = 0;
let fejlesztesekdiv = fejlesztesek.map(fejlesztes => new UpgradeDiv(fejlesztes));

let Income = setInterval(() => {
    fejlesztesekdiv.forEach(fdiv =>{
         if(fdiv.u.type == "w"){
            words += fdiv.u.quantity * fdiv.u.generate
        }
        else{
            verseskotetek += fdiv.u.quantity * fdiv.u.generate
        }
    })
    
    SzamFrissit(words, versek, verseskotetek);
    
}, 1000)

KiirasFrissit(fejlesztesekdiv);
function music(){

    let mySound = new Audio("Szoó Virág_ A lázadó imája.mp3")
    mySound.play()
}
// window.addEventListener("click", music)
var budosszar = 0
window.addEventListener("click", () => {
    budosszar += 1;
    if(budosszar == 1){
        music()
    }
})