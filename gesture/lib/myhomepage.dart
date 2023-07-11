import 'package:flutter/material.dart';

class myHomePage extends StatelessWidget {
  const myHomePage({Key? key, required this.title}) : super(key: key);
  final String title;

  @override
  Widget build(BuildContext context) {
  return Scaffold(
    appBar: AppBar(
      title:const Text('GeeksForGeeks'),
      backgroundColor: Colors.green,
    ),
    body: const Center(child: GestureDectors())
  );
  }
}
class GestureDectors extends StatelessWidget {
  const GestureDectors({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      child:Card(
        child: Text('Click on Me'),
      ),
        onTap: (){
          print('Card is Tapped');
        },
      onDoubleTap: () => print('Card is double tapped'),

      onLongPress: (){
        print('Card is long pressed');
      }

    );
  }
}

