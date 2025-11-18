var applicantList = [
    { name: "Alex", image: "images/m1.png",  location: "Thrissur", course: "Btech", experience: "2 years"  },
    { name: "Ameya", image: "./images/m2.png", location: "Palakkad", course: "MCA", experience: "2 years" },
    { name: "Ommer", image: "./images/m1.png", location: "Kochi", course: "BCA", experience: "4 years" },
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

        var location=document.createElement('p');
        location.textContent =applicantList[value].location;

        var course=document.createElement('p');
        course.textContent =applicantList[value].course;

        var experience=document.createElement('p');
        experience.textContent=applicantList[value].experience;
        // console.log(item.image);
        cardDiv.appendChild(image);
        cardDiv.appendChild(name);
        cardDiv.appendChild(location);
        cardDiv.appendChild(course);
        cardDiv.appendChild(experience);
        contentDiv.appendChild(cardDiv);
   
   }
    
}
