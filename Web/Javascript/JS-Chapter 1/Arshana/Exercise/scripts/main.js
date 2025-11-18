function validateForm()
{
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var role=document.getElementById("role").value;
    var location=document.getElementById("location").value; 
    var website=document.getElementById("website").value;
     if(name==null  || name=="")
    {
        alert("Please Enter Name");
        return false;
    }
  
    if(email==null || email=="")
    {
        alert("Please Enter Email");
        return false;
    }
    if(phone==null  || phone=="")
    {
        alert("Please Enter Phone Number");
        return false;
    }
    if(role=="" || role==null)
    {
        alert("Please Enter Role");
        return false;
    }
    if(location==null || location=="")
    {
        alert("Please Enter Location");
        return false;
    }
    if(website==null || website=="")
    {
        alert("Please Enter Website");
        return false;
   
    }
    return true;
} 

function validateMail()
{
    const pattern= /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

   if(!pattern.test(email))
   {
        alert("Please enter valid mail");
        return false;
   }
   return true;
}

function validateNum()
{
    const patterns = /^(\+91[\-\s]?)?[6-9]\d{9}$/;

   if(!patterns.test(phone))
   {
        alert("Please enter valid number");
        return false;
   }
   return true;
}

