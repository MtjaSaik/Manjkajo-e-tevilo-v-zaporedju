function manjkajocaStevilka() {
    let dejanskaVsota = 0;
    let vnos = document.getElementById("vnos").value;
    let stevilke = vnos.split(",");
    let zaporedje = [];

    for (let i = 0; i < stevilke.length; i++) {
        zaporedje.push(parseInt(stevilke[i].trim()));
    }

    let dolzina = zaporedje.length + 1;
    let pricakovanaVsota = (dolzina * (dolzina + 1)) / 2;

    for (let j = 0; j < zaporedje.length; j++) {
        dejanskaVsota += zaporedje[j];
    }

    let manjkajocaStevilka = pricakovanaVsota - dejanskaVsota;
    document.getElementById("rezultat").textContent = "Manjkajoče število je: " + manjkajocaStevilka;
}