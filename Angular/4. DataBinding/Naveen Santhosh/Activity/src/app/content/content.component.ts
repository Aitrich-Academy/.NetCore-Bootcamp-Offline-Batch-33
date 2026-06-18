import { Component } from '@angular/core';



@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
studentName = "Naveen" ;
age = "21";

isDisabled = true;

image1 = "/assets/images/Group 8.png";
image2 ="/assets/images/profilePicture.png";
image3 ="/assets/images/images.jpg";

textColor = "black";

username = ' ';

islightON = true;

num = 0 ;

rating! : number;

employees = [
  {name : "Naveen" , isManager : true},
   {name : "Abijith" , isManager : false},
    {name : "Aswin" , isManager : false},
     {name : "Edwin" , isManager : false},
      {name : "Benlin" , isManager : true}
];

fruits = ["Apple","Grapes","Pineapple","Orange","Tomato"] ;

toggleButton(){
  this.isDisabled = !this.isDisabled;
}

changeImage(){
  this.image1 = this.image2;
}
changetextColor(){
  this.textColor = "red";
}

lightOFF(){
  this.islightON = !this.islightON;
}

incrementNum(){
  this.num = this.num +1;
}
decrementNum(){
  this.num = this.num -1 ;
}

}
