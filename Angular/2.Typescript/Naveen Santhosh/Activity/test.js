"use strict";
// // questione 1
// let bookTitle : string="Williom words worth";
// let isAvailable:boolean=true;
// let publicationYear:number=2005;
// let genres:string[]=["nature", "rain"];
// // questione 2
// enum ThemeMode{
//     light="light",
//     dark ="dark",
//     system="system"
// }
// const currentThemeMode: ThemeMode = ThemeMode.dark;
// // questione 3
// interface Product {
//     id : number;
//     title : string;
//     price : number;
//     tags : string[];
//     discountPercentage?: number;
// }
// const laptop : Product = {
//     id : 1,
//     title:"laptop",
//     price:66000,
//     tags:["good","worth"],
//     discountPercentage: 25
// }
// // questione 4
// let coordinates: [number, number] = [40.7128, -74.0060];
// // positive, negative or zero
// let num: number = 0;
// if(num > 0){
// console.log("Number is positive");
// }else if(num < 0){
// console.log("Number is negative");
// }else{
//     console.log("Number is zero");
// }
// // largest of three numbers
// let num1 : number = 2;
// let num2 : number = 4;
// let num3 : number = 6;
// if(num1 > num2 && num1 > num3){
//   console.log(num1 + " is the greatest number");
// }else if(num2 > num1 && num2 >  num3){
// console.log(num2 + " is the greatest number");
// }else if(num3 > num1 && num3 > num2){
// console.log(num3 + " is the greatest number");
// }
// // grading system
// let grade : number = 49;
// if(grade >=90){
// console.log("Excellent, A grade");
// }else if(grade >= 75 && grade <= 89){
// console.log("good, B grade");
// }else if(grade >= 50 && grade <=74){
// console.log("nice, C grade");
// }else if(grade < 50 ){
// console.log("sorry bro you are failed🤣");
// }
// // day name
// let day: number = 5;
// switch(day){
// case 1:
//     console.log("Sunday");
//     break;
// case 2:
//     console.log("Monday"); 
//     break;
// case 3:  
//     console.log("Tuesday"); 
//     break;
// case 4:
//     console.log("Wednesday"); 
//     break;
// case 5:
//     console.log("Thursday");
//     break;
// case 6:
//     console.log("Friday"); 
//     break;  
// case 7:
//     console.log("Saturday"); 
//     break;   
// default:
//     console.log("please enter a valid day");
//     break;
// }
// // vowel or consonant
// let vowels:string[]=['a','e','i','o','u'];
// let character: string = 'w';
// if(character.length ! == 1){
// console.log("please enter a single alphabet");
// }else if(vowels.includes(character)){
// console.log("chracter is a vowel");
// }else {
//   console.log("chracter is a consonant");  
// }
// // print all even numbers
// for(let i:number=1; i<=50 ; i++){
// if(i % 2 ===0){
// console.log(i);
// }
// }
// // sum of first n numbers
// let n: number= 10;
// let sum : number = 0 ;
// for(let i = 0 ; i <= n ; i++){
// sum += i;
// }
// console.log("sum = " + sum);
// // multiplication table
// let number: number = 5;
// let product: number = 1;
// for(let i = 0; i <= 10; i++){
//  product = i * number;
//  console.log(i +"*" + number + "=" + product);
// }
// Reverse a number
let num4 = 123;
let reversed = 0;
while (num4 > 0) {
    reversed = reversed * 10 + (num4 % 10);
    num4 = Math.floor(num4 / 10);
}
console.log(reversed);
// pattern
for (let i = 1; i <= 4; i++) {
    let pattern = "";
    for (let j = 1; j <= i; j++) {
        pattern += "*";
    }
    console.log(pattern);
}
// factorial of a number
let numm = 5;
let fact = 1;
for (let i = 1; i <= numm; i++) {
    fact *= i;
}
console.log(fact);
