namespace Maple2.Trigger._02000441_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{85000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305}, arg2: true);
                context.SetActor(triggerId: 3001, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 3002, visible: true, initialSequence: "Closed");
                context.SetInteractObject(interactIds: new []{10001096}, state: 0);
                context.SetInteractObject(interactIds: new []{10001097, 10001098}, state: 2);
                context.SetBreakable(triggerIds: new []{1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816, 1817, 1818, 1819, 1820, 1821, 1830, 1831, 1832, 1833, 1834, 1835, 1836, 1837, 1838, 1839, 1840, 1841, 1842, 1843, 1844, 1845, 1846, 1847, 1848, 1849, 1850, 1851, 1852, 1853, 1854, 1855, 1856, 1857, 1858, 1859, 1860, 1861, 1862, 1863, 1864, 1865, 1866, 1867, 1868, 1869, 1870, 1871}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "start") == 1) {
                    return new StateQuestDungeonStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestDungeonStart : TriggerState {
            internal StateQuestDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8100, enable: true);
            }

            public override TriggerState? Execute() {
                return new StateMermaid_01(context);
            }

            public override void OnExit() { }
        }

        private class StateMermaid_01 : TriggerState {
            internal StateMermaid_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: false);
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateMermaid_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMermaid_02 : TriggerState {
            internal StateMermaid_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetSkip(state: new StateScene_04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMermaid_02_talk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMermaid_02_talk : TriggerState {
            internal StateMermaid_02_talk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000441_BF__MAIN__1$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.CameraSelect(triggerId: 8006, enable: true);
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__2$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000441_BF__MAIN__19$", arg4: 3, arg5: 3);
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__3$", arg4: 3, arg5: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2002");
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__4$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Attack_01_A");
                context.SetMesh(triggerIds: new []{7001, 7002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 3001, visible: true, initialSequence: "Opening");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateOpen_door_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen_door_01 : TriggerState {
            internal StateOpen_door_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__5$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000441_BF__MAIN__6$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 8100, enable: true);
                context.SetBreakable(triggerIds: new []{1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816, 1817, 1818, 1819, 1820, 1821}, enabled: true);
                context.SetEffect(triggerIds: new []{7101}, visible: true);
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2004");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{703})) {
                    return new StateBattle_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_01 : TriggerState {
            internal StateBattle_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8100, enable: true);
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__7$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000441_BF__MAIN__8$", arg4: 2, arg5: 1);
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202})) {
                    return new StateBattle_01_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_01_2 : TriggerState {
            internal StateBattle_01_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{20101, 20202, 20303, 20404, 20505, 20606, 20708, 20408}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{20101, 20202, 20303, 20404, 20505, 20606, 20708, 20408})) {
                    return new StateBattle_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_02 : TriggerState {
            internal StateBattle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateOpen_door_03(context));
                context.CameraSelect(triggerId: 8007, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2005");
                context.SetConversation(type: 1, spawnId: 101, script: "$02000441_BF__MAIN__9$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 704, spawnIds: new []{101})) {
                    return new StateOpen_door_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen_door_ready : TriggerState {
            internal StateOpen_door_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateOpen_door_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen_door_02 : TriggerState {
            internal StateOpen_door_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2007");
                context.SetMesh(triggerIds: new []{7003, 7004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 3002, visible: true, initialSequence: "Opening");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateOpen_door_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen_door_03 : TriggerState {
            internal StateOpen_door_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 8100, enable: true);
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2008");
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__10$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000441_BF__MAIN__11$", arg4: 2, arg5: 0);
                context.SetBreakable(triggerIds: new []{1830, 1831, 1832, 1833, 1834, 1835, 1836, 1837, 1838, 1839, 1840, 1841, 1842, 1843, 1844, 1845, 1846, 1847, 1848, 1849, 1850}, enabled: true);
                context.SetEffect(triggerIds: new []{7102}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateOpen_door_03_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen_door_03_2 : TriggerState {
            internal StateOpen_door_03_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{707})) {
                    return new StateOpen_door_03_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen_door_03_3 : TriggerState {
            internal StateOpen_door_03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{205, 206, 207, 208, 209}, arg2: true);
                context.SetUserValue(triggerId: 2038806, key: "monster_respawn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{209})) {
                    return new StateBattle_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_03 : TriggerState {
            internal StateBattle_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__12$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000441_BF__MAIN__13$", arg4: 2, arg5: 2);
                context.SetInteractObject(interactIds: new []{10001096}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001096}, arg2: 0)) {
                    return new StateBattle_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_04 : TriggerState {
            internal StateBattle_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7103}, visible: true);
                context.SetBreakable(triggerIds: new []{1851, 1852, 1853, 1854, 1855, 1856, 1857, 1858, 1859, 1860, 1861, 1862, 1863, 1864, 1865, 1866, 1867, 1868, 1869, 1870, 1871}, enabled: true);
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__14$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000441_BF__MAIN__15$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMove_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMove_02 : TriggerState {
            internal StateMove_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2010");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2009");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{705})) {
                    return new StateShip_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShip_01 : TriggerState {
            internal StateShip_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$02000441_BF__MAIN__16$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000441_BF__MAIN__17$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{706})) {
                    return new StateShip_01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShip_01_1 : TriggerState {
            internal StateShip_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{301, 302, 303, 304, 305})) {
                    return new StateShip_01_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{401, 402}, arg2: true);
                context.SetUserValue(triggerId: 2038805, key: "monster_buff", value: 1);
            }
        }

        private class StateShip_01_2 : TriggerState {
            internal StateShip_01_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{401, 402})) {
                    return new StateShip_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShip_02 : TriggerState {
            internal StateShip_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001097, 10001098}, state: 1);
                context.SetEventUI(arg1: 1, script: "$02000441_BF__MAIN__18$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001097}, arg2: 0)) {
                    return new StateShip_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShip_03 : TriggerState {
            internal StateShip_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001098}, arg2: 0)) {
                    return new StateShip_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShip_end : TriggerState {
            internal StateShip_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StateEnding_02(context));
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding : TriggerState {
            internal StateEnding(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7104}, visible: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8003, 8004, 8005, 8006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEnding_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_02 : TriggerState {
            internal StateEnding_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnding_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_03 : TriggerState {
            internal StateEnding_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000442, portalId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_04 : TriggerState {
            internal StateEnding_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetLocalCamera(cameraId: 8100, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7101, 7102, 7103, 7104}, visible: false);
                context.DestroyMonster(spawnIds: new []{101, 102});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
