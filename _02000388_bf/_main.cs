using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000388_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {301, 302, 303, 304, 305}, arg2: true);
                context.SetActor(arg1: 3001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 3002, arg2: true, arg3: "Closed");
                context.SetInteractObject(arg1: new int[] {10001096}, arg2: 1);
                context.SetBreakable(
                    arg1: new int[] {
                        1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816,
                        1817, 1818, 1819, 1820, 1821
                    }, arg2: false);
                context.SetBreakable(
                    arg1: new int[] {
                        1830, 1831, 1832, 1833, 1834, 1835, 1836, 1837, 1838, 1839, 1840, 1841, 1842, 1843, 1844, 1845,
                        1846, 1847, 1848, 1849, 1850
                    }, arg2: false);
                context.SetBreakable(
                    arg1: new int[] {
                        1851, 1852, 1853, 1854, 1855, 1856, 1857, 1858, 1859, 1860, 1861, 1862, 1863, 1864, 1865, 1866,
                        1867, 1868, 1869, 1870, 1871
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701")) {
                    context.State = new StateRoomCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new StateQuestDungeonStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8100, enable: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "702")) {
                    context.State = new Statemermaid_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestDungeonStart : TriggerState {
            internal StateQuestDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8100, enable: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {702}, arg2: new int[] {50001517},
                    arg3: new byte[] {1})) {
                    context.State = new Statemermaid_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {702}, arg2: new int[] {50001517},
                    arg3: new byte[] {2})) {
                    context.State = new Statemoveuser_00(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {702}, arg2: new int[] {50001518},
                    arg3: new byte[] {1})) {
                    context.State = new Statemoveuser_00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemoveuser_00 : TriggerState {
            internal Statemoveuser_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000390, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statemermaid_01 : TriggerState {
            internal Statemermaid_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: 0);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new Statemermaid_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemermaid_02 : TriggerState {
            internal Statemermaid_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.SetSkip(arg1: "scene_04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statemermaid_02_talk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemermaid_02_talk : TriggerState {
            internal Statemermaid_02_talk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000388_BF__MAIN__1$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.CameraSelect(arg1: 8006, arg2: true);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__2$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000388_BF__MAIN__3$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__4$", arg4: 3, arg5: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__5$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_01_A");
                context.SetMesh(arg1: new int[] {7001, 7002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 3001, arg2: true, arg3: "Opening");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateopen_door_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopen_door_01 : TriggerState {
            internal Stateopen_door_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__6$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000388_BF__MAIN__7$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 8100, enable: true);
                context.SetBreakable(
                    arg1: new int[] {
                        1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816,
                        1817, 1818, 1819, 1820, 1821
                    }, arg2: true);
                context.SetEffect(arg1: new int[] {7101}, arg2: true);
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2004");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "703")) {
                    context.State = new Statebattle_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle_01 : TriggerState {
            internal Statebattle_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8100, enable: true);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__8$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000388_BF__MAIN__9$", arg4: 2, arg5: 1);
                context.CreateMonster(arg1: new int[] {201, 202, 203, 204}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201, 202, 203, 204})) {
                    context.State = new Statebattle_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle_02 : TriggerState {
            internal Statebattle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "open_door_03");
                context.CameraSelect(arg1: 8007, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2005");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000388_BF__MAIN__10$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 704, arg2: new int[] {101})) {
                    context.State = new Stateopen_door_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopen_door_ready : TriggerState {
            internal Stateopen_door_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Stateopen_door_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopen_door_02 : TriggerState {
            internal Stateopen_door_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2007");
                context.SetMesh(arg1: new int[] {7003, 7004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 3002, arg2: true, arg3: "Opening");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateopen_door_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopen_door_03 : TriggerState {
            internal Stateopen_door_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 8100, enable: true);
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2008");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__11$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000388_BF__MAIN__12$", arg4: 2, arg5: 0);
                context.SetBreakable(
                    arg1: new int[] {
                        1830, 1831, 1832, 1833, 1834, 1835, 1836, 1837, 1838, 1839, 1840, 1841, 1842, 1843, 1844, 1845,
                        1846, 1847, 1848, 1849, 1850
                    }, arg2: true);
                context.SetEffect(arg1: new int[] {7102}, arg2: true);
                context.CreateMonster(arg1: new int[] {205, 206, 207, 208, 209}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {205, 206, 207, 208, 209})) {
                    context.State = new Statebattle_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle_03 : TriggerState {
            internal Statebattle_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__13$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000388_BF__MAIN__14$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001096}, arg2: 0)) {
                    context.State = new Statebattle_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle_04 : TriggerState {
            internal Statebattle_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7103}, arg2: true);
                context.SetBreakable(
                    arg1: new int[] {
                        1851, 1852, 1853, 1854, 1855, 1856, 1857, 1858, 1859, 1860, 1861, 1862, 1863, 1864, 1865, 1866,
                        1867, 1868, 1869, 1870, 1871
                    }, arg2: true);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__15$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000388_BF__MAIN__16$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statemove_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemove_02 : TriggerState {
            internal Statemove_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2010");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2009");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "705")) {
                    context.State = new Stateship_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateship_01 : TriggerState {
            internal Stateship_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000388_BF__MAIN__17$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000388_BF__MAIN__18$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "706")) {
                    context.State = new Stateship_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateship_02 : TriggerState {
            internal Stateship_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000388_BF__MAIN__19$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001097}, arg2: 0)) {
                    context.State = new Stateship_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateship_03 : TriggerState {
            internal Stateship_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001098}, arg2: 0)) {
                    context.State = new Stateship_end(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateship_end : TriggerState {
            internal Stateship_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "ending_02");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateending(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending : TriggerState {
            internal Stateending(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7104}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {8003, 8004, 8005, 8006}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Stateending_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_02 : TriggerState {
            internal Stateending_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateending_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_03 : TriggerState {
            internal Stateending_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000389, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateending_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_04 : TriggerState {
            internal Stateending_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetLocalCamera(cameraId: 8100, enable: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7101}, arg2: false);
                context.SetEffect(arg1: new int[] {7102}, arg2: false);
                context.SetEffect(arg1: new int[] {7103}, arg2: false);
                context.SetEffect(arg1: new int[] {7104}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101, 102});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}