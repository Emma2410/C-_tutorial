import 'package:flutter/material.dart';
import 'package:gesture/myhomepage.dart';
import 'package:gesture/listview.dart';
import 'package:gesture/theme/mainpage.dart';
import 'package:gesture/theme/theme_const.dart';
import 'package:gesture/theme/theme_manager.dart';

void main() => runApp(const MyApp());

ThemeManager _themeManager = ThemeManager();

class MyApp extends StatefulWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  State<MyApp> createState() => _MyAppState();
}

class _MyAppState extends State<MyApp> {

  @override
  void  dispose(){
    _themeManager.removeListener(themeListener);
    super.dispose();
  }

  @override
  void initState(){
    _themeManager.addListener(themeListener);
    super.initState();
  }

  themeListener(){
    if(mounted){
      setState(() {

      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Flutter Demo',
      theme: lightTheme,
      darkTheme: darkTheme,
      themeMode: _themeManager.themeMode,
      home:MyHomeScreen(),
    );
  }
}



class MyHomeScreen extends StatefulWidget {
  const MyHomeScreen({Key? key}) : super(key: key);

  @override
  State<MyHomeScreen> createState() => _MyHomeScreenState();
}

class _MyHomeScreenState extends State<MyHomeScreen> {
  @override
  Widget build(BuildContext context) {
    TextTheme _textTheme = Theme.of(context).textTheme;
    bool isDark = Theme.of(context).brightness == Brightness.dark;
    return Scaffold(
      appBar: AppBar(
        title: Text('Theme App'),
        actions: [Switch(value: _themeManager.themeMode == ThemeMode.dark, onChanged: (newValue){
          _themeManager.toggleTheme(newValue);
        })],

      ),
      body: Center(child: ElevatedButton(child: Text('Click me'), onPressed: (){},)),
    );
  }
}
