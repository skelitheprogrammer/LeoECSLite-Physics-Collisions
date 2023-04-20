# LeoECSLite Physics. Collisions
> [Демо репозиторий](https://github.com/skelitheprogrammer/ECS-Collisions-Demo)

# Содержание

* [Подключение](#Подключение)
  * [Создание ентитей](#Создание-ентитей)
  * [Синхронизация объектов с ецс](#Синхронизация-объектов-с-ецс)  
* [Контакты](#Контакты)

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

# Подключение
##Создание ентитей
Чтобы создать ентитю-коллизию, нужно добавить `CollisionComponent` `GameObjectReferenceComponent` компоненты
##Синхронизация объектов с ецс
Нужно добавить `SyncCollisionsSystem` после всех систем, обарабатывающих данные `CollisionComponent`  

# Контакты
E-mail: dosynkirill@gmail.com </br>
Discord: @skilli на [сервере дискорд](#Социальные-ресурсы)
