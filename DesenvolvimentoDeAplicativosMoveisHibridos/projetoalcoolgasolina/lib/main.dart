import 'package:flutter/material.dart';

void main() {
  runApp(MaterialApp(
    home: Home(),
    debugShowCheckedModeBanner: false,
  ));
}

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(
          "Álcool ou Gasolina",
          style: TextStyle(color: Colors.white),
        ),
        centerTitle: true,
        backgroundColor: Colors.lightBlue[900],
      ),
      body: SingleChildScrollView(
        padding: EdgeInsets.fromLTRB(10.0, 0, 10.0, 0),
        child: Form(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: [
              Icon(
                Icons.local_gas_station_rounded,
                size: 160.0,
                color: Colors.lightBlue[900],
              ),
              TextFormField(
                textAlign: TextAlign.center,
                keyboardType: TextInputType.numberWithOptions(decimal: true),
                style: TextStyle(color: Colors.lightBlue[900], fontSize: 26.0),
                decoration: InputDecoration(
                    labelText: "Valor da Gasolina",
                    labelStyle: TextStyle(color: Colors.lightBlue[900])),
              ),
              TextFormField(
                textAlign: TextAlign.center,
                keyboardType: TextInputType.numberWithOptions(decimal: true),
                style: TextStyle(color: Colors.lightBlue[900], fontSize: 26.0),
                decoration: InputDecoration(
                    labelText: "Valor da Álcool",
                    labelStyle: TextStyle(color: Colors.lightBlue[900])),
              ),
              Padding(
                padding: EdgeInsets.only(top: 20.0, bottom: 20.0),
                child: Container(
                  height: 50.0,
                  child: ElevatedButton(
                    onPressed: () {},
                    child: Text('Verificar'),
                    style: ElevatedButton.styleFrom(
                        primary: Colors.lightBlue[900],
                        onPrimary: Colors.white,
                        textStyle: TextStyle(fontSize: 25.0)),
                  ),
                ),
              )
              //PARAMOS AQUI
            ],
          ),
        ),
      ),
    );
  }
}