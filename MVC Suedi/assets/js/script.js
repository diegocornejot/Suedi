// Variables
document.getElementById("Btn_login").addEventListener("click", action_login);
document.getElementById("Btn_register").addEventListener("click", action_register);
window.addEventListener("resize", width_page);

var container_login_register = document.querySelector(".container_login-register");
var form_login = document.querySelector(".form_login");
var form_register = document.querySelector(".form_register");
var box_back_login = document.querySelector(".box_back-login");
var box_back_register = document.querySelector(".box_back-register");

function width_page(){
    if(window.innerWidth > 850){
        box_back_login.style.display = "block";
        box_back_register.style.display = "block";
    } else {
        box_back_register.style.display = "block";
        box_back_register.style.opacity = "1";
        box_back_login.style.display = "none";
        form_login.style.display = "block";
        form_register.style.display = "none";
        container_login_register.style.left = "0px";
    }
}

width_page();

function action_login(){
    if(window.innerWidth > 850){
        form_register.style.display = "none";
        container_login_register.style.left = "10px";
        form_login.style.display = "block";
        box_back_register.style.opacity = "1";
        box_back_login.style.opacity = "0";
    } else {
        form_register.style.display = "none";
        container_login_register.style.left = "0px";
        form_login.style.display = "block";
        box_back_register.style.display = "block";
        box_back_login.style.display = "none";
    }
}

function action_register(){

    if(window.innerWidth > 850){
        form_register.style.display = "block";
        container_login_register.style.left = "410px";
        form_login.style.display = "none";
        box_back_register.style.opacity = "0";
        box_back_login.style.opacity = "1";
    } else {
        form_register.style.display = "block";
        container_login_register.style.left = "0px";
        form_login.style.display = "none";
        box_back_register.style.display = "none";
        box_back_login.style.display = "block";
        box_back_login.style.opacity = "1";
    }  
}