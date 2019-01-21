using System.Data.Entity.Migrations;
using System.Linq;
using Models.SysModels;

namespace Services.Migrations
{
    public class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            #region ��ҵ

            //var sysEnterprises = new[]
            //{
            //    new SysEnterprise
            //    {
            //        Id = "defaultEnt",
            //        EnterpriseName = "��򾭼ü���������Ͷ�ʴٽ�����"
            //    },
            //    //new SysEnterprise
            //    //{
            //    //    Id = "TestEnt",
            //    //    EnterpriseName = "������ҵ"
            //    //}
            //};
            //context.SysEnterprises.AddOrUpdate(a => new {a.Id}, sysEnterprises);

            #endregion

            #region SysArea

            var sysAreas = new[]
            {
                new SysArea
                {
                    AreaName = "Platform",
                    Name = "����ƽ̨",
                    SystemId = "002"
                }
            };
            context.SysAreas.AddOrUpdate(a => new {a.AreaName, a.Name, a.SystemId}, sysAreas);

            #endregion

            #region SysAction

            var sysActions = new[]
            {
                new SysAction
                {
                    Name = "�б�",
                    ActionName = "Index",
                    SystemId = "001",
                    System = true
                },
                new SysAction
                {
                    Name = "��ϸ",
                    ActionName = "Details",
                    SystemId = "003",
                    System = true
                },
                new SysAction
                {
                    Name = "�½�",
                    ActionName = "Create",
                    SystemId = "004",
                    System = true
                },
                new SysAction
                {
                    Name = "�༭",
                    ActionName = "Edit",
                    SystemId = "005",
                    System = true
                },
                new SysAction
                {
                    Name = "ɾ��",
                    ActionName = "Delete",
                    SystemId = "006",
                    System = true
                },
                new SysAction
                {
                    Name = "����",
                    ActionName = "Report",
                    SystemId = "007",
                    System = true
                }
            };
            context.SysActions.AddOrUpdate(a => new {a.ActionName}, sysActions);

            #endregion

            #region SysController

            var sysControllers = new[]
            {
                #region �������� 100
                new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "��½����ƽ̨",
                    ControllerName = "Index",
                    SystemId = "100",
                    Display = false
                },
                new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "����",
                    ControllerName = "Desktop",
                    SystemId = "100100",
                    Display = false
                },
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "ʹ�ð���",
                //    ControllerName = "Help",
                //    SystemId = "100200",
                //    Display = false
                //},
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��Ϣ����",
                //    ControllerName = "MyMessage",
                //    SystemId = "100300",
                //    Display = false
                //},
                new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "�޸�����",
                    ControllerName = "ChangePassword",
                    SystemId = "100400",
                    Display = false
                },

                #endregion other                

                //#region ��վ���� 200
                new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "��վ����",
                    ControllerName = "Index",
                    SystemId = "200",
                    Ico = "fa-globe",
                    Display = true
                },
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��Ŀ����",
                //    ControllerName = "CmsCategory",
                //    SystemId = "200005",
                //    Ico = "fa-newspaper-o"
                //},
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��Ѷ����",
                //    ControllerName = "CmsArtical",
                //    SystemId = "200100",
                //    Ico = "fa-newspaper-o",
                //    Display = false,
                //},
                //  new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "����Ժ��Ϣ",
                //    ControllerName = "StateCouncil",
                //    SystemId = "200105",
                //    Ico = "fa-newspaper-o",
                    
                //},
                
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��ҵ֮��",
                //    ControllerName = "CompanyInfo",
                //    SystemId = "200110",
                //    Ico = "fa-newspaper-o",
                //},
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��Ʒ����",
                //    ControllerName = "TedaProductManage",
                //    SystemId = "200200",
                //    Ico = "fa-newspaper-o",
                //},
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��ȼƻ�",
                //    ControllerName = "AnnualPlan",
                //    SystemId = "200250",
                //    Ico = "fa-newspaper-o",
                //},
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��Ʒ��",
                //    ControllerName = "ProductBook",
                //    SystemId = "200300",
                //    Ico = "fa-newspaper-o",
                //},
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��������",
                //    ControllerName = "AboutUs",
                //    SystemId = "200750",
                //    Ico = "fa-list-ul",
                //    Display = false,
                //},

                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��Ա����",
                //    ControllerName = "MemberManagement",
                //    SystemId = "200800",
                //    Ico = "fa-address-card"
                //},
                //  new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "���԰����",
                //    ControllerName = "Consultation",
                //    SystemId = "200850",
                //    Ico = "fa-list-ul"
                //},
                #endregion

                #region ϵͳ���� 900
                new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "ϵͳ����",
                    ControllerName = "Index",
                    SystemId = "900",
                    Ico = "fa-cogs",
                    Display = true
                },
                   new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "��֯�ܹ�",
                    ControllerName = "SysDepartment",
                    SystemId = "900100",
                    Ico = "fa-building-o",
                },
                new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "��ɫ����",
                    ControllerName = "SysRole",
                    SystemId = "900300",
                    Ico = "fa-street-view"
                },
                new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "�û�����",
                    ControllerName = "SysUser",
                    SystemId = "900400",
                    Ico = "fa-user-circle-o"
                },
               
                #endregion
                #region ϵͳ�������� 950
                new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "ϵͳ����",
                    ControllerName = "Index",
                    SystemId = "950",
                    Ico = "fa-cog"
                },
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "��������",
                //    ControllerName = "SysAction",
                //    SystemId = "950300",
                //    Ico = "fa-th-large"
                //},
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "ϵͳģ��",
                //    ControllerName = "SysController",
                //    SystemId = "950400",
                //    Ico = "fa-puzzle-piece"
                //},
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "������Ϣ",
                //    ControllerName = "SysHelp",
                //    SystemId = "950900",
                //    Ico = "fa-info-circle"
                //},
                //new SysController
                //{
                //    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                //    Name = "������Ϣ����",
                //    ControllerName = "SysHelpClass",
                //    SystemId = "950950",
                //    Ico = "fa-info-circle"
                //},
                new SysController
                {
                    SysAreaId = sysAreas.Single(a => a.AreaName == "Platform").Id,
                    Name = "�û���־",
                    ControllerName = "SysUserLog",
                    SystemId = "950990",
                    Ico = "fa-calendar"
                },

                #endregion
            };

            context.SysControllers.AddOrUpdate(
                a => new {a.SysAreaId, a.SystemId}, sysControllers);

     

            #region SysControllerSysAction

            var sysControllerSysActions = (from sysAction in sysActions.Where(a => a.System)
                from sysController in sysControllers
                select
                new SysControllerSysAction
                {
                    SysActionId = sysAction.Id,
                    SysControllerId = sysController.Id
                }).ToArray();

            context.SysControllerSysActions.AddOrUpdate(a => new {a.SysActionId, a.SysControllerId},
                sysControllerSysActions);

            #endregion

            #region ģ������Action

            context.SysControllerSysActions.AddOrUpdate(a => new {a.SysActionId, a.SysControllerId});

            #endregion

            #region ��ɫ����

            //�Զ�������Ҫ��Ȩ�����ù���
            var ids4SysControllerSysActions = sysControllerSysActions.Select(a => a.Id).ToList();
            context.SysRoleSysControllerSysActions.RemoveRange(
                context.SysRoleSysControllerSysActions.Where(
                    rc =>
                        rc.SysControllerSysAction.SysAction.System &&
                        !ids4SysControllerSysActions.Contains(rc.SysControllerSysActionId)).ToList());
            //context.Commit(); ʵʱ�ύһ���Ƿ��ܽ���ظ������⣿

            //����ϵͳ����Ա
            var sysRole = new SysRole
            {
                Id = "admin",
                Name = "ϵͳ����Ա",
                RoleName = "ϵͳ����Ա",
                SysDefault = true,
                SystemId = "999",
                //EnterpriseId = ent.Id
                //ϵͳ����Ա�Զ��������Ȩ��
                //SysRoleSysControllerSysActions = (from aa in sysControllerSysActions select new SysRoleSysControllerSysAction { SysControllerSysActionId = aa.Id, RoleId = "admin-" + ent.Id }).ToArray()
            };
            context.SysRoles.AddOrUpdate(sysRole);
            //ϵͳ����Ա�Զ��������Ȩ��
            var sysRoleSysControllerSysActions = (from aa in sysControllerSysActions
                                                  select
                                                  new SysRoleSysControllerSysAction
                                                  {
                                                      SysControllerSysActionId = aa.Id,
                                                      RoleId = sysRole.Id
                                                  }).ToArray();
            context.SysRoleSysControllerSysActions.AddOrUpdate(rc => new { rc.RoleId, rc.SysControllerSysActionId },
                sysRoleSysControllerSysActions);
            //foreach (var ent in sysEnterprises)
            //{
            //    //����ϵͳ����Ա
            //    var sysRole = new SysRole
            //    {
            //        Id = "admin-" + ent.Id,
            //        Name = ent.EnterpriseName + "ϵͳ����Ա",
            //        RoleName = "ϵͳ����Ա",
            //        SysDefault = true,
            //        SystemId = "999",
            //        EnterpriseId = ent.Id
            //        //ϵͳ����Ա�Զ��������Ȩ��
            //        //SysRoleSysControllerSysActions = (from aa in sysControllerSysActions select new SysRoleSysControllerSysAction { SysControllerSysActionId = aa.Id, RoleId = "admin-" + ent.Id }).ToArray()
            //    };
            //    context.SysRoles.AddOrUpdate(sysRole);
            //    //ϵͳ����Ա�Զ��������Ȩ��
            //    var sysRoleSysControllerSysActions = (from aa in sysControllerSysActions
            //        select
            //        new SysRoleSysControllerSysAction
            //        {
            //            SysControllerSysActionId = aa.Id,
            //            RoleId = sysRole.Id
            //        }).ToArray();
            //    context.SysRoleSysControllerSysActions.AddOrUpdate(rc => new {rc.RoleId, rc.SysControllerSysActionId},
            //        sysRoleSysControllerSysActions);
            //}

            #endregion
        }
    }
}