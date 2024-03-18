using ToDtoExtension;

UserEntity userEntity = new(id: 1,
                            username: "Lucas",
                            email: "lucas@email.com",
                            password: "!@EHG&YHBU$J");

UserDto userDto = userEntity.ToDto();

Console.WriteLine(userDto);