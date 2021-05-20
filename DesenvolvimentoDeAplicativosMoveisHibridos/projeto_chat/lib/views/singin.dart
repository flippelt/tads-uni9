import 'package:app_chat/widgets/widget.dart';
import 'package:flutter/material.dart';

class SignIn extends StatefulWidget {
  @override
  _SignInState createState() => _SignInState();
}

class _SignInState extends State<SignIn> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: appBarMain(context),
      body: Container(
        padding: EdgeInsets.symmetric(horizontal: 24.0),
        child: Column(
          children: [
            TextField(
              style: simpleTextFieldStyle(),
              decoration: textFieldInputDecoration("email"),
            ),
            TextField(
              style: simpleTextFieldStyle(),
              decoration: textFieldInputDecoration("password"),
            ),
            SizedBox(height: 8),
            Container(
              alignment: Alignment.centerRight,
              child: Container(
                padding: EdgeInsets.symmetric(horizontal: 16.0, vertical: 8.0),
                child: Text(
                  "Forgot Password?",
                  style: simpleTextFieldStyle(),
                ),
              ),
            ),
            SizedBox(height: 8.0),
            Container(),
          ],
        ),
      ),
    );
  }
}
