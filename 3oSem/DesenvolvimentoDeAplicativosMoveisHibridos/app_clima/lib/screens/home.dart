import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:searchable_dropdown/searchable_dropdown.dart';
import 'package:http/http.dart' as http;
import 'package:app_clima/model/clima_model.dart';

class Home extends StatefulWidget {
  const Home({Key key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  ClimaData climaData;
  bool isLoading = false;
  List<String> _cidades = [
    'Aracaju',
    'Belém',
    'Belo Horizonte',
    'Boa Vista',
    'Brasilia',
    'Campinas',
    'Campo Grande',
    'Cuiabá',
    'Curitiba',
    'Florianópolis',
    'Fortaleza',
    'Goiânia',
    'Grenoble',
    'João Pessoa',
    'Macapá',
    'Maceió',
    'Manaus',
    'Natal',
    'Palmas',
    'Porto Alegre',
    'Porto Velho',
    'Recife',
    'Rio Branco',
    'Rio de Janeiro',
    'Salvador',
    'São Luiz',
    'São Paulo',
    'Teresina',
    'Vitoria'
  ];

  String _cidadeSelecionada = 'São Paulo';

  onLoadWeather() async {
    setState(() {
      isLoading = true;
    });

    final String _appid = 'c800c4e5b99b74559a81a68ba9013ad9';
    final String _lang = 'pt_br';
    final String _units = 'metric';
    final String _apiURL = 'api.openweathermap.org';
    final String _path = '/data/2.5/weather';
    final _params = {
      'q': _cidadeSelecionada,
      'appid': _appid,
      'units': _units,
      'lang': _lang
    };

    final weatherResponse = await http.get(Uri.https(_apiURL, _path, _params));

    if (weatherResponse.statusCode == 200) {
      setState(() {
        isLoading = false;
        climaData = ClimaData.fromJson(jsonDecode(weatherResponse.body));
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(_cidadeSelecionada),
        centerTitle: true,
      ),
      body: Center(
        child: Column(
          children: [
            SearchableDropdown.single(
              items: _cidades
                  .map((e) => DropdownMenuItem(value: e, child: Text(e)))
                  .toList(),
              onChanged: (value) {
                setState(() {
                  _cidadeSelecionada = value;
                  onLoadWeather();
                });
              },
              displayClearIcon: false,
              value: _cidadeSelecionada,
              icon: Icon(Icons.location_on),
              isExpanded: true,
              closeButton: "Fechar",
            ),
            Expanded(
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Padding(
                    padding: EdgeInsets.all(6.0),
                    child: isLoading
                        ? CircularProgressIndicator(
                            strokeWidth: 3.0,
                            valueColor: new AlwaysStoppedAnimation(Colors.blue),
                          )
                        : Container(),
                  )
                ],
              ),
            )
          ],
        ),
      ),
    );
  }
}
