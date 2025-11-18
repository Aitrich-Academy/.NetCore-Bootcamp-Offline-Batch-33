var applicantList = [
    { name: "Alex", image: "images/m1.png", location: "Thrissur", sub: "Btech", experience: "2 years" },
    { name: "Ameya", image: "./images/m2.png", location: "Thrissur", sub: "Btech", experience: "2 years" },
    { name: "Ommer", image: "./images/m1.png", location: "Thrissur", sub: "Btech", experience: "4 years" },
];
listApplicants();
function listApplicants() {
    var contentDiv = document.getElementById('card');
    var content = document.getElementById('content');
   
   for(let value in applicantList) {

        //creating div for each item in the array
        var cardDiv = document.createElement('p');

        var image = document.createElement('img');
        image.src = applicantList[value].image;

        var name=document.createElement('b');
        name.textContent = applicantList[value].name;

        var experience=document.createElement('p');
        experience.textContent=applicantList[value].experience;

        var location=document.createElement('p');
        location.textContent=applicantList[value].location;

        var sub=document.createElement('p');
        sub.textContent=applicantList[value].sub;
        
        // console.log(item.image);
        cardDiv.appendChild(image);
        cardDiv.appendChild(name);
        cardDiv.appendChild(experience);
        cardDiv.appendChild(location);
        cardDiv.appendChild(sub);
        contentDiv.appendChild(cardDiv);
   
   }
    
}
