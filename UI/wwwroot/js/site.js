// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Bootsrapt table oluşturma metotu
function Veri_Listele(_url, id) {
    var table = $(`#${id}`);
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (liste) {
            table.bootstrapTable('load', liste);
            table.bootstrapTable({ data: liste });
        },
        error: function (err) {
            alert('HATA');
            console.log(err);
        }
    });
};
function Veri_Ekle(_url, id, _data = null) {
    var frm = $('#' + id);
    if (_data == null) {
        _data = JSON.stringify(frm.serializeJSON());
    }
    $.ajax({
        url: _url,
        method: 'POST',
        data: _data,
        async: false,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (result) {
            alert('Verileriniz başarı ile eklenmiştir!');
            window.location.reload();
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
function Veri_Sil(_url, nesne) {
    var _data = JSON.stringify(nesne);
    $.ajax({
        url: _url,
        method: 'DELETE',
        dataType: 'json',
        data: _data,
        async: false,
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            alert('Veriler Başarıyla Silindi.');
            window.location.reload();
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
function Veri_Guncelle(_url, nesne) {
    if (nesne != null) {
        var _data = JSON.stringify(nesne);
    }
    else {
        alert('Güncelleme yapılacak alan boş geldiği için Hata meydana geldi!');
    }
    $.ajax({
        url: _url,
        method: 'PUT',
        data: _data,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (result) {
            alert('Güncelleme işlemi başarıyla gerçekleşti!');
            window.location.reload();
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
function Veri_Getir_KursIcin(_url, data) {
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        data: { id: data },
        async: false,
        success: function (result) {
            $('#KursAdGuncelle').val(result.name);
            $('#KursKoduGuncelle').val(result.code);
            $('#KursIcerikGuncelle').val(result.content);
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
function KursTextBoxDoldur(id, name, code, content) {
    this.id = id;
    this.name = name;
    this.code = code;
    this.content = content;
};
//Selectbox veri doldurmak için kullanılır.
function Fakulte_Listele(_url, id) {
    var obj = $(`#${id}`);
    obj.empty();
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (result) {
            for (var i = 0; i < result.length; i++) {
                obj.append(
                    `<option value="${result[i].id}">${result[i].name}</option>`
                );
            }
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
//Bu kısmı yorumdan çıkarmayınız!!!
//function Veri_Getir_DepartmanIcin(_url, data) {
//    $.ajax({
//        url: _url,
//        method: 'GET',
//        dataType: 'json',
//        data: { id: data },
//        async: false,
//        success: function (result) {
//            $('#DepartmantAdGuncelle').val(result.name);
//            $('#FacultyGuncelle').val(result.facultyId);
//        },
//        error: function (err) {
//            console.log(err);
//            alert('HATA');
//        }
//    });
//};
function DepartmanTextBoxDoldur(id, name, facultyId) {
    this.id = id;
    this.name = name;
    this.facultyId = facultyId;
};

function Veri_Getir_FakulteIcin(_url, data) {
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        data: { id: data },
        async: false,
        success: function (result) {
            $('#FakulteAdGuncelle').val(result.name);
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
function FakulteTextBoxDoldur(id, name) {
    this.id = id;
    this.name = name;
};
function Gonder(location) {
    window.location.href = location;
};
//Selectbox veri doldurmak için kullanılır.
function Departman_Listele(_url, id) {
    var obj = $(`#${id}`);
    obj.empty();
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (result) {
            for (var i = 0; i < result.length; i++) {
                obj.append(
                    `<option value="${result[i].id}">${result[i].name}</option>`
                );
            }
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
//Selectbox veri doldurmak için kullanılır.
function Kurs_Listele(_url, id) {
    var obj = $(`#${id}`);
    obj.empty();
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (result) {
            for (var i = 0; i < result.length; i++) {
                obj.append(
                    `<option value="${result[i].id}">${result[i].name}</option>`
                );
            }
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
function Student_Listele(_url, id) {
    var obj = $(`#${id}`);
    obj.empty();
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (result) {
            for (var i = 0; i < result.length; i++) {
                obj.append(
                    `<option value="${result[i].id}">${result[i].name} ${result[i].surname}</option>`
                );
            }
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};
function Instructor_Listele(_url, id) {
    var obj = $(`#${id}`);
    obj.empty();
    $.ajax({
        url: _url,
        method: 'GET',
        dataType: 'json',
        async: false,
        success: function (result) {
            for (var i = 0; i < result.length; i++) {
                obj.append(
                    `<option value="${result[i].id}">${result[i].name} ${result[i].surname}</option>`
                );
            }
        },
        error: function (err) {
            console.log(err);
            alert('HATA');
        }
    });
};