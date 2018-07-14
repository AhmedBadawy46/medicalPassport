$(".nav a").on("click", function () {
    $(".nav").find(".active").removeClass("active");
    $(this).parent().addClass("active");
});

let changeContent = (() => {
    let x = $('#contentDiv')
    let familyLi = $('#familyLi')
    familyLi.on('click', () => {
        x.empty()
        $.ajax({
            type: "Get",
            data: {
            },
            url: '/Profile/mainData/GetFamilyData',

            success: function (response) {
                x.append(response)
            },
            failure: function (errMsg) {
                console.log("error")
            }

        });
    })

    let basicDataLi = $('#basicDataLi')
    basicDataLi.on('click', () => {
        x.empty()
        $.ajax({
            type: "Get",
            data: {
            },
            url: '/Profile/mainData/GetBasicData',

            success: function (response) {
                x.append(response)
            },
            failure: function (errMsg) {
                console.log("error")
            }

        });
    })

    let IDoctorLi = $('#IDoctorLi')
    IDoctorLi.on('click', () => {
        x.empty()
        $.ajax({
            type: "Get",
            data: {
            },
            url: '/Doctors/profile/GetAgreementLicense',

            success: function (response) {
                x.append(response)
            },
            failure: function (errMsg) {
                console.log("error")
            }

        });
    })
    let Doctor_BasicInfo = $('#Doctor_BasicInfo')
    Doctor_BasicInfo.on('click', () => {
        x.empty()
        $.ajax({
            type: "Get",
            data: {
            },
            url: '/Doctors/profile/GetBasicInfo',

            success: function (response) {
                x.append(response)
            },
            failure: function (errMsg) {
                console.log("error")
            }

        });
    })

    let Doctor_Facility = $('#Doctor_Facility')
    Doctor_Facility.on('click', () => {
        x.empty()
        $.ajax({
            type: "Get",
            data: {
            },
            url: '/Doctors/profile/GetFacilityData',

            success: function (response) {
                x.append(response)
            },
            failure: function (errMsg) {
                console.log("error")
            }

        });
    })
})()
