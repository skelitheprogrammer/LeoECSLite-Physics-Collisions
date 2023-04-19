# LeoECSLite Physics. Collisions

# Содержание

* [Подключение](#Подключение)

# Установка

> **ВАЖНО!**
> <br>Зависит от [LeoECS Lite](https://github.com/Leopotam/ecslite) - фреймворк должен быть установлен до этого расширения.
> <br> Зависит от [Skillitronic LeoECS Lite Common](https://github.com/skelitheprogrammer/Skillitronic-LeoECSLite-Common)

## В виде unity модуля

Поддерживается установка в виде unity-модуля через git-ссылку в PackageManager:

```
https://github.com/skelitheprogrammer/LeoECSLite-Physics-Collisions.git
```

или прямое редактирование `Packages/manifest.json`:

```
"com.skillitronic.leoecslite.physics.collisions": "https://github.com/skelitheprogrammer/LeoECSLite-Physics-Collisions.git",
```

# Как работает
## Collision Beahviour Классы
`ECSCollisionBehaviour` - абстрактный класс, позволяющим реализовать отправку сигналов с физики в ECS.
* `ECSObjectTriggerBehaviour` - обрабатывает `OnTriggerEnter` `OnTriggerExit` 
* `ECSObjectCollisionBehaviour` - обрабатывает `OnCollisionEnter` `OnCollisionExit`
> Требует наличие `EntityReferenceHolder` компонента, чтобы знать у какой ентити произошла коллизия

##Создание ентитей
Чтобы создать ентитю-коллизию, нужно добавить `CollisionComponent`, 
который будет держать в себе данные о произошедшей коллизии

# Подключение
