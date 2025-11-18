function btnsignUp(){
    const UserName = document.getElementById("userName").value;
    const UserEmail = document.getElementById("email").value;
    const UserNumber = document.getElementById("phoneNumber").value;

    if(!UserName || !UserEmail || !UserNumber){
        alert("Please fill in all fields.");
        return;
    }
    
    alert(`${UserName}, you have successfully signed up for the newsletter!`);
}
