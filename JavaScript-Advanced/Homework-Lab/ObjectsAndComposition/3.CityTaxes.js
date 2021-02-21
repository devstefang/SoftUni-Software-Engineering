function cityTaxes(name,population,treasury){
    return  {
        name,
        population,
        treasury,
        taxrate: 10,
        collectTaxes(){
            this.treasury += this.population * this.taxrate;
        },
        applyGrowth(percent){
            this.population += Math.floor(this.population * this.percent /100);
        },
        applyRecession(percent){
            this.treasury -= Math.floor(this.treasury * this.percent / 100);
        }
    };
    
}
cityTaxes('Tortuga',
7000,
15000
)