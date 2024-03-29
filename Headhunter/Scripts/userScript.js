﻿// Получение всех пользователей
function GetUsers() {
    $.ajax({
        url: '/api/user',
        type: 'GET',
        contentType: "application/json",
        success: function (users) {
            var rows = "";
            $.each(users, function (index, user) {
                // добавляем полученные элементы в таблицу
                rows += row(user);
            });
            $("table tbody").append(rows);
        }
    });
}
// Получение одного пользователя
function GetUser(id) {
    $.ajax({
        url: '/api/user/' + id,
        type: 'GET',
        contentType: "application/json",
        success: function (user) {
            var form = document.forms["userForm"];
            form.elements["id"].value = user.id;
            form.elements["login"].value = user.name;
            form.elements["email"].value = user.age;
        }
    });
}
// Добавление пользователя
function CreateUser(userLogin, userPassword, userEmail) {
    $.ajax({
        url: "api/user",
        contentType: "application/json",
        method: "POST",
        data: JSON.stringify({
            login: userLogin,
            password: userPassword,
            email: userEmail
        }),
        success: function (user) {
            reset();
            $("table tbody").append(row(user));
        }
    })
}
// Изменение пользователя
function EditUser(userId, userName, userAge) {
    $.ajax({
        url: "api/user",
        contentType: "application/json",
        method: "PUT",
        data: JSON.stringify({
            id: userId,
            name: userName,
            age: userAge
        }),
        success: function (user) {
            reset();
            $("tr[data-rowid='" + user.id + "']").replaceWith(row(user));
        }
    })
}

// сброс формы
function reset() {
    var form = document.forms["userForm"];
    form.reset();
    form.elements["id"].value = 0;
}

// Удаление пользователя
function DeleteUser(id) {
    $.ajax({
        url: "api/user/" + id,
        contentType: "application/json",
        method: "DELETE",
        success: function (user) {
            $("tr[data-rowid='" + user.id + "']").remove();
        }
    })
}
// создание строки для таблицы
var row = function (user) {
    return "<tr data-rowid='" + user.id + "'><td>" + user.id + "</td>" +
        "<td>" + user.name + "</td> <td>" + user.age + "</td>" +
        "<td><a class='editLink' data-id='" + user.id + "'>Изменить</a> | " +
        "<a class='removeLink' data-id='" + user.id + "'>Удалить</a></td></tr>";
}
// сброс значений формы
$("#reset").click(function (e) {

    e.preventDefault();
    reset();
})

// отправка формы
$("form").submit(function (e) {
    e.preventDefault();
    var id = this.elements["id"].value;
    var name = this.elements["name"].value;
    var age = this.elements["age"].value;
    if (id == 0)
        CreateUser(name, age);
    else
        EditUser(id, name, age);
});

// нажимаем на ссылку Изменить
$("body").on("click", ".editLink", function () {
    var id = $(this).data("id");
    GetUser(id);
})
// нажимаем на ссылку Удалить
$("body").on("click", ".removeLink", function () {
    var id = $(this).data("id");
    DeleteUser(id);
})

// загрузка пользователей
GetUsers();