function Validar() {
	ValidarText();
	ValidarTel();
	ValidarPass();
	ValidarCorreo();
	Fecha();

};


	function addCarrera() {
		var productTable = document.getElementById("productTable");
		var rowCount = productTable.rows.length;
		var row = productTable.insertRow(rowCount);
		var IdCarrera = row.insertCell(0);
		var description = row.insertCell(1);
		var removeButton = row.insertCell(2);


		IdCarrera.innerHTML = document.getElementById("IdCarrera").value;
		description.innerHTML = document.getElementById("DesCarrera").value;

		var butt = document.createElement('input');
		butt.setAttribute('type', 'button');
		butt.setAttribute('name', 'remove');
		butt.setAttribute('value', '-');
		butt.onclick = function () {
			removeProduct(productTable, this);
		}
		//row.cells[3].appendChild(butt);

	}

function ValidarText() {
	$("input[type='text']").each(function () {
		var texto = $(this).val();
		texto = texto.trim();
		if (texto.length === 0) {
			alert('Revise el campo ' + this.name);
		} else {

			alert('Esta bien');
		}
	})

};

function ValidarTel() {

	var tel = $("input[name='Telefono']").val();
	tel = tel.trim();
	if (/^([0-9]{8})$/i.test(tel)) {
		alert("correcto");
	} else {
		alert("Ingrese un Telefono valido");
	}

};

function ValidarPass() {
	$("input[type='password']").each(function () {
		var texto = $(this).val();
		texto = texto.trim();
		if (texto.length < 8) {
			alert('Revise el campo ' + this.name);
		} else {

			alert('Esta bien');
		}
	})

};

function ValidarCorreo() {


	var correo = $("input[name='Correo']").val();
	correo = correo.trim();

	if ((/^[-\w.%+]{1,64}@(?:[A-Z0-9-]{1,63}\.){1,125}[A-Z]{2,63}$/i).test(correo)) {

		alert('Esta bien')
	} else {
		alert('Ingrese un Correo Valido')

	}
};

function Fecha() {

	var dato = $("input[name='fecha']").val();

	if ((/([12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01]))$/).test(dato)) {
		alert('is ok');
	} else {
		alert('is not ok');
	}
};


//carne
//2018 1234

function Label() {
	LabelDate();
	LabelTime();
};

function LabelDate() {
	var meses = new Array("Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre");
	var f = new Date();
	var fech = (f.getDate() + " de " + meses[f.getMonth()] + " de " + f.getFullYear());
	document.getElementById('lbl_date').innerText = fech;
};

function LabelTime() {
	var fecha = new Date()
	var hora = fecha.getHours()
	var minuto = fecha.getMinutes()
	var segundo = fecha.getSeconds()

	if (hora < 10) { hora = "0" + hora }
	if (minuto < 10) { minuto = "0" + minuto }
	if (segundo < 10) { segundo = "0" + segundo }
	var horita = hora + ":" + minuto + ":" + segundo
	document.getElementById('lbl_time').innerText = horita;
};

function EditarNota() {
	$('.Nota').attr('contenteditable', true);
};

function GuardarNota() {
	ValidarNota();
	$('.Nota').attr('contenteditable', false);
};

function ValidarNota() {
	$(".Nota").each(function () {
		var nota = $(this).html();
		nota = nota.trim();
		if (nota.length < 1 || nota.length > 3 || nota > 100 || nota < 0 || /^[0-9]*$/i.test(nota) == false) {
			alert('La nota: ' + nota + ' no es valida.');
			$(this).html(85);
		}else{
			alert('La nota fue cambiada satisfactoriamente');
		}
	})
};







