(function () {

    $(function () {
        var _personService = abp.services.app.person;

        var _$modal = $("#PersonCreateModal");

        var _$form = _$modal.find('form');
        //api/services/app/Person/CreateOrUpdatePersonAsync
        //api/services/app/Person/PrintHelloAsync

        //添加联系人
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();
            if (!_$form.valid()) {
                return;
            }
            var personEditDto = _$form.serializeFormToObject();//序列化为对象
            personEditDto.PhoneNumbers = [];
            var PhoneNumber = {};

            PhoneNumber.Type = personEditDto.PhoneNumberType;
            PhoneNumber.Number = personEditDto.PhoneNumber;
            personEditDto.PhoneNumbers.push(PhoneNumber);

            abp.ui.setBusy(_$modal);
            _personService.createUpdatePerson({ personEditDto }).done(function () {
                _$modal.modal('hide');
                location.reload(true);
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });

        });

        //刷新
        $('#RefreshButton').click(function (e) {
            e.preventDefault();
            refreshPersonList();
        });

        function refreshPersonList() {
            location.reload(true);
        }

        $('.delete-person').click(function () {
            var personId = $(this).attr("data-person-id");
            var personName = $(this).attr("data-person-name");
            deletePerson(personId, personName);
        });

        function deletePerson(id, name) {
            abp.message.confirm("是否删除姓名为：" + name + "的联系人",
                function (isConfirmed) {
                    _personService.deletePerson({ id }).done(function () {
                        refreshPersonList();
                    });
                });

        }

        //编辑
        $('.edit-person').click(function (e) {
            e.preventDefault();
            var personId = $(this).attr("data-person-id");
            _personService.getPersonForEdit({ id: personId }).done(function (data) {

                $("input[name=Id]").val(data.person.id);
                $("input[name=Name]").val(data.person.name).parent().addClass("focused");
                $("input[name=EmailAddress]").val(data.person.emailAddress).parent().addClass("focused");
                $("input[name=Address]").val(data.person.address).parent().addClass("focused");
                $("input[name=PhoneNumber]").val(data.person.phoneNumbers[0].number).parent().addClass("focused");
                $("select[name=PhoneNumberType]").selectpicker('val', data.person.phoneNumbers[0].type);
            });
        });

        $('#PersonCreateModal').on("hide.bas.modal",
            function () {
                _$form[0].reset();
        });

        //$('#seeHello').click(function (e) {
        //    e.preventDefault();
        //    if (!_$form.valid()) {
        //        return;
        //    }
        //    var personEditDto = _$form.serializeFormToObject();//序列化为对象
        //    console.log(personEditDto);

        //    abp.ui.setBusy(_$modal);
        //    _personService.printHello({ personEditDto }).done(function () {
        //        _$modal.modal('hide');
        //        location.reload(true);
        //    }).always(function () {
        //        abp.ui.clearBusy(_$modal);
        //    });
        //})
    });


})();





