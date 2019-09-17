function openPage(pageName, elmnt, color) {
    // Hide all elements with class="tabcontent" by default */
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Remove the background color of all tablinks/buttons
    tablinks = document.getElementsByClassName("tablink");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].style.backgroundColor = "";
    }

    // Show the specific tab content
    document.getElementById(pageName).style.display = "block";

    // Add the specific color to the button used to open the tab content
    elmnt.style.backgroundColor = color;
}


// When the user scrolls down 20px from the top of the document, show the button

// function scrollFunction() {
//     if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200) {
//         document.getElementById("myBtn").style.display = "block";
//     } else {
//         document.getElementById("myBtn").style.display = "none";
//     }
// }

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}

// Выпадающий список резюме
function openNav() {
    document.getElementById("myNav").style.width = "100%";

    $.ajax({
        url: "http://localhost:5000/api/resume/userLogin/" + localStorage.getItem("userLogin"),
        contentType: "application/json",
        type: "GET",
        success: function(data) {
            data.forEach(function(item, i, data) {
                $(".overlay-content").html(" ");
              $(".overlay-content").append("<a style='background:white; opacity:0.6;text-align:center;' onclick='ApplyToVacancy(" + item.id + ")'>" + item.desiredPosition + ". З/П: " + item.desiredSalary + " тенге." + "</a>");
            });
        }
    });
}

/* Close when someone clicks on the "x" symbol inside the overlay */
function closeNav() {
    document.getElementById("myNav").style.width = "0%";
}
// Выпадающий список резюме


function openPage(pageName, elmnt, color) {
    // Hide all elements with class="tabcontent" by default */
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Remove the background color of all tablinks/buttons
    tablinks = document.getElementsByClassName("tablink");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].style.backgroundColor = "";
    }

    // Show the specific tab content
    document.getElementById(pageName).style.display = "block";

    // Add the specific color to the button used to open the tab content
    elmnt.style.backgroundColor = color;
}

// Get the element with id="defaultOpen" and click on it
// $(document).ready(function() {
//     document.getElementById("defaultOpen").click();
// });

//--------------------------------------------------АЛИБИ КОД----------------------------------------------------------

function LoadHeaderInfo() {
    $("#profileBtn").html(localStorage.getItem("userLogin"));
}

function seenotification(id) {
    $.ajax({
        url: "http://localhost:5000/api/vacancy/seenotification/" + id,
        contentType: "application/json",
        method: "POST",
        success: function() {
            document.location.href = "IndexASSP.html";
        }
    })
}

function signIn(userLogin, userPassword) {
    $.ajax({
        url: "http://localhost:5000/api/user/SignIn",
        contentType: "application/json",
        method: "POST",
        data: JSON.stringify({
            login: userLogin,
            password: userPassword,
        }),

        success: function(user) {
            localStorage.setItem("userLogin", userLogin);
            localStorage.setItem("userId", user.id);
            document.location.href = "IndexASSP.html";
        }
    })
};

function signUp(fullName, userLogin, userPassword) {
    $.ajax({
        url: "http://localhost:5000/api/user/SignUp",
        contentType: "application/json",
        method: "POST",
        data: JSON.stringify({
            fullName: fullName,
            login: userLogin,
            password: userPassword,
        }),

        success: function() {
            alert("Регистрация прошла успешно!");
        }
    })
};

function openVacancy(id) {
    $.ajax({
        url: "http://localhost:5000/api/vacancy/id/" + id,
        contentType: "application/json",
        method: "GET",
        success: function(data) {
            localStorage.setItem("vacancyId", data.id);
            document.location.href = "IndexVacancy.html";
        }
    });
}

function close() {

    window.location.href = "IndexASSP.html";
}



function ApplyToVacancy(resumeId) {
    $.ajax({
        url: "http://localhost:5000/api/vacancy/ApplyToVacancy",
        contentType: "application/json",
        method: "POST",
        data: JSON.stringify({
            resumeId: resumeId,
            vacancyId: localStorage.getItem("vacancyId")
        }),
        success: function() {
            alert("Вы откликнулиь на эту вакансию!");
        }
    });
}

function goToNewVacancyPage() {
    document.location.href = "IndexResume.html";
}

function goToNewResumesPage() {
    document.location.href = "IndexRealResume.html";
}


function setCitiesValues() {
    $.ajax({
        url: "http://localhost:5000/api/cities",
        contentType: "application/json",
        type: "GET",
        success: function(data) {
            data.forEach(function(item, i, data) {
                $("#city").append("<option value='" + item.name + "'>" + item.name + "</option>");
            });
        }
    });
}

function inviteToJob(userId, vacancyId) {
    $.ajax({
        url: "http://localhost:5000/api/vacancy/invitetojob",
        contentType: "application/json",
        type: "POST",
        data: JSON.stringify({
            userId: userId,
            vacancyId: vacancyId
        }),
        success: function(data) {
            alert("Приглашение отправлено!");
        }
    });
}

function goToResume(resumeId) {
    $.ajax({
        url: "http://localhost:5000/api/resume/id/" + resumeId,
        contentType: "application/json",
        method: "GET",
        success: function(data) {
            localStorage.setItem("resumeId", resumeId);
            document.location.href = "Resume.html";
        }
    })
};

function getResumeInfo(resumeId) {
    $.ajax({
        url: "http://localhost:5000/api/resume/id/" + resumeId,
        contentType: "application/json",
        method: "GET",
        success: function(data) {
            $("#fullName").append(data.fullName);
            $("#email").append(data.email);
            $("#desiredPosition").append(data.desiredPosition);
            $("#desiredSalary").append(data.desiredSalary);
            $("#highEducations").append(data.highEducations);
            $("#skills").append(data.skills);
            $("#description").append(data.description);
            $("#languagesKnowledge").append(data.languagesKnowledge);
            $("#learnedCourses").append(data.learnedCourses);
            localStorage.setItem("resumeOwnerId", data.ownerId);
        }
    })
}

function createResume() {
    debugger;
    const resume = {
        fullName: $("#fullName").val(),
        city: $("#city").val(),
        ableToRelocate: $('#ableToRelocate').prop('checked'),
        desiredPosition: $('#desiredPosition').val(),
        hasExperience: $('#hasExperience').prop('checked'),
        desiredSalary: $('#desiredSalary').val(),
        highEducations: $('#highEducations').val(),
        skills: $("#skills").val(),
        description: $("#description").val(),
        languagesKnowledge: $("#languagesKnowledge").val(),
        learnedCourses: $("#learnedCourses").val(),
        ownerLogin: localStorage.getItem("userLogin")
    }
    debugger;
    const json = JSON.stringify(resume);
    debugger;
    $.ajax({
        url: "http://localhost:5000/api/resume",
        contentType: "application/json",
        type: "POST",
        data: json,
        success: alert("URA!")
    });
};

$("#profileBtn").click(function() {
    document.location.href = "IndexProfile.html";
});
