document.addEventListener("DOMContentLoaded", function () {

    const fields = [
        "engName",
        "arbName",
        "fromDate",
        "toDate",
        "btnSave"
    ];

    fields.forEach(function (id, index) {

        const item = document.getElementById(id);

        if (!item) return;

        item.addEventListener("keydown", function (e) {

            if (e.key === "Enter") {

                e.preventDefault();

                if (index < fields.length - 1) {

                    const next =
                        document.getElementById(fields[index + 1]);

                    if (next) {
                        next.focus();
                    }
                }
            }

        });

    });

});