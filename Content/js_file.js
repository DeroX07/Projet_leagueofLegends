$(document).ready(function () {
    $(document).on('click', ".selectteam", function (e) {
        e.preventDefault();
        $("tr .equipe").remove();
        var id = $(this).attr("id");
        console.log(id);
        var Data = { id: id };
        var check 
        $.ajax({
            type: "POST",
            url: '/Joueur/GetPlayer',
            data: Data,
            dataType: "json",
            success: function (data) {
                console.log(data);
                var txt = `
                <tr class="equipe">
                    <td>
                        ${data[0].NameJoueur}
                    </td>
                    <td>
                        ${data[1].NameJoueur}
                    </td>
                    <td>
                        ${data[2].NameJoueur}
                    </td>
                    <td>
                        ${data[3].NameJoueur}
                    </td>
                    <td>
                        ${data[4].NameJoueur}
                    </td>
                </tr>
                          `
                $("tr").append(txt)
                console.log(txt);
            }
        })
    })
})