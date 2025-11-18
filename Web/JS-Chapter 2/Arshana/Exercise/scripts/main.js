var applicantList = [
    { job: "Social Media Assistant", image: "./images/Company Logo (2).png", location: "Thrissur", sub: "Btech", experience: "2 years" },
    { job: "Brand Designer", image: "./images/Logo.png", location: "Thrissur", sub: "Btech", experience: "4 years" },
    { job: "Customer Manager", image: "./images/Logo 27.png", location: "Thrissur", sub: "Btech", experience: "2 years" },
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

        var job=document.createElement('b');
        job.textContent = applicantList[value].job;

        var experience=document.createElement('p');
        experience.textContent=applicantList[value].experience;

        var location=document.createElement('p');
        location.textContent=applicantList[value].location;

        var sub=document.createElement('p');
        sub.textContent=applicantList[value].sub;
        
        // console.log(item.image);
        
        cardDiv.appendChild(job);
        cardDiv.appendChild(experience);
        cardDiv.appendChild(image);
        cardDiv.appendChild(location);
        cardDiv.appendChild(sub);
        contentDiv.appendChild(cardDiv);
   
   }
    
}
