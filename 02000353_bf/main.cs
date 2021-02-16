using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000353_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 6001, 6002, 6003, 6004, 6101, 6301, 6302}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001, 2002, 2003, 2004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {901, 902, 903}, arg2: false, arg4: 0, arg5: 10f);
                context.SetSkill(arg1: new[] {2020}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 101, textId: 40010);
                context.SetEffect(arg1: new[] {6001, 6002, 6003, 6004, 6101}, arg2: true);
                context.SetActor(arg1: 3001, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 3002, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 3003, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 3004, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 3101, arg2: false, arg3: "Dmg_A");
                context.CreateMonster(arg1: new[] {11, 12, 13, 14, 15, 101, 102, 103, 104, 105, 106, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {11, 12, 13, 14, 15})) {
                    return new State관문_01_개방전(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 101);
            }
        }

        private class State관문_01_개방전 : TriggerState {
            internal State관문_01_개방전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000353_BF__MAIN__2$", arg3: 2000);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSkip(state: new State관문_02_스킵(context));
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_01_개방_이벤트_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_이벤트_00 : TriggerState {
            internal State관문_01_개방_이벤트_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_01_개방_이벤트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_이벤트_01 : TriggerState {
            internal State관문_01_개방_이벤트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2001, 2002}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_01_개방_이벤트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_이벤트_02 : TriggerState {
            internal State관문_01_개방_이벤트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2003}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_01_개방_이벤트_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_이벤트_03 : TriggerState {
            internal State관문_01_개방_이벤트_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2004}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State관문_02_시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
            }
        }

        private class State관문_02_스킵 : TriggerState {
            internal State관문_02_스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2001, 2002, 2003, 2004}, arg2: true);
                context.SetSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.RemoveBuff(arg1: 199, arg2: 70000107);
                    return new State관문_02_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_시작 : TriggerState {
            internal State관문_02_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.CameraSelect(arg1: 8001, arg2: false);
                context.ShowGuideSummary(entityId: 103, textId: 40011);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new State관문_02_시작_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 103);
            }
        }

        private class State관문_02_시작_02 : TriggerState {
            internal State관문_02_시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6005, 6006, 6007, 6008}, arg2: true);
                context.SetActor(arg1: 3005, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 3006, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 3007, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 3008, arg2: false, arg3: "Dmg_A");
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 101, textId: 40010);
                context.CreateMonster(arg1: new[] {21, 22, 23, 24, 25, 26, 27}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {21, 22, 23, 24, 25, 26, 27})) {
                    return new State관문_02_개방전(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 101);
            }
        }

        private class State관문_02_개방전 : TriggerState {
            internal State관문_02_개방전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000353_BF__MAIN__3$", arg3: 2000);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_02_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State관문_02_개방_이벤트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방_이벤트_01 : TriggerState {
            internal State관문_02_개방_이벤트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2006}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_02_개방_이벤트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방_이벤트_02 : TriggerState {
            internal State관문_02_개방_이벤트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2007}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_02_개방_이벤트_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방_이벤트_03 : TriggerState {
            internal State관문_02_개방_이벤트_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2008}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_03_시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_시작_01 : TriggerState {
            internal State관문_03_시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 103, textId: 40011);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 704) == 1) {
                    return new State관문_03_시작_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 103);
            }
        }

        private class State관문_03_시작_02 : TriggerState {
            internal State관문_03_시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 101, textId: 40010);
                context.SetEffect(arg1: new[] {6301, 6302}, arg2: true);
                context.SetActor(arg1: 3301, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 3302, arg2: false, arg3: "Dmg_A");
                context.CreateMonster(arg1: new[] {31, 32, 33}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {31, 32, 33})) {
                    return new State관문_03_개방전(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 101);
            }
        }

        private class State관문_03_개방전 : TriggerState {
            internal State관문_03_개방전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000353_BF__MAIN__4$", arg3: 2000);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_03_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State관문_03_개방_이벤트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방_이벤트_01 : TriggerState {
            internal State관문_03_개방_이벤트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2009}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_03_개방_이벤트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방_이벤트_02 : TriggerState {
            internal State관문_03_개방_이벤트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2010}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State관문_03_개방_이벤트_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방_이벤트_03 : TriggerState {
            internal State관문_03_개방_이벤트_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2011}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State지역Clear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역Clear : TriggerState {
            internal State지역Clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 103, textId: 40009);
                context.SetMesh(arg1: new[] {6006}, arg2: false, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {6007}, arg2: true, arg4: 0, arg5: 10f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}