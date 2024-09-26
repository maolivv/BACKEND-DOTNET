using desafio_poo_dio.Models;

// instanciando o iPhone
Iphone iphone = new("21999999", "iPhone 15 PRO Max", "seila oq é isso", 128);

// instanciando o Nokia
Nokia nokia = new("44999999", "Nokia M5", "nsei", 240);

// ligando iPhone
iphone.Ligar();

// ligando Nokia
nokia.Ligar();

// receber ligação no iPhone
iphone.ReceberLigacao();

// receber ligação no Nokia
nokia.ReceberLigacao();

// instalando app no iPhone
iphone.InstalarAplicativo("Poo");

// instalando app no Nokia
nokia.InstalarAplicativo("WhatsApp");