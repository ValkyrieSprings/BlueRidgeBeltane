using System;

namespace BrbFestApp.Common
{
    public class Constants
    {
        public class Sql
        {
            public const string ConfigQry = @"select 
                (
                    SELECT Id, Name
                    FROM ItemType
                    ORDER BY Id
                    for json path, root('ItemTypes')
                ) as ItemTypes, 
                (
                    SELECT i.Id, i.Title, i.ShortDescription, i.LongDescription, t.Name AS ItemTypeName
                    FROM  InfoItem AS i INNER JOIN ItemType AS t ON i.ItemTypeId = t.Id
                    ORDER BY i.Title
                    for json path, root('InfoItems')
                ) as InfoItems, 
                (
                    SELECT TOP (100) PERCENT dbo.Person.Id, dbo.Person.Name, dbo.Person.Bio, dbo.Person.ImageFile, t.Name AS ItemTypeName
                    FROM ItemType AS t INNER JOIN Person ON t.Id = Person.ItemTypeId
                    ORDER BY dbo.Person.Name
                    for json path, root('Persons')
                ) as Persons, 
                (
                    SELECT ScheduleItem.Id, ScheduleItem.ShortDescription, ScheduleItem.FullDescription, ScheduleItem.StartDateTime, ScheduleItem.EndDateTime, ScheduleItem.ImageFile, ItemType.Name AS ItemTypeName
                    FROM ScheduleItem INNER JOIN ItemType ON ScheduleItem.ItemTypeId = ItemType.Id
                    ORDER BY ScheduleItem.StartDateTime, ScheduleItem.EndDateTime
                    for json path, root('ScheduleItems')
                ) as ScheduleItems, 
                (
                    SELECT Id, PersonId, ScheduleItemId, IsPrimary
                    FROM xScheduleItem_Person
                    for json path, root('xScheduleItem_Persons')
                ) as xScheduleItem_Persons,
                (
                    SELECT Id, Setting, Value
                    FROM Settings
                    ORDER BY Setting
                    for json path, root('Settings')
                ) as 'Settings'";
        }
    }
}
