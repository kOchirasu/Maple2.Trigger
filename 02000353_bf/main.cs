using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000353_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 6001, 6002, 6003, 6004, 6101, 6301, 6302}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5004}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{901, 902, 903}, visible: false, arg4: 0, arg5: 10f);
                context.SetSkill(triggerIds: new []{2020}, arg2: true);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 101, textId: 40010);
                context.SetEffect(triggerIds: new []{6001, 6002, 6003, 6004, 6101}, visible: true);
                context.SetActor(triggerId: 3001, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 3002, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 3003, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 3004, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 3101, visible: false, initialSequence: "Dmg_A");
                context.CreateMonster(spawnIds: new []{11, 12, 13, 14, 15, 101, 102, 103, 104, 105, 106, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{11, 12, 13, 14, 15})) {
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
                context.SetEventUI(arg1: 1, script: "$02000353_BF__MAIN__2$", duration: 2000);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new State관문_02_스킵(context));
                context.CameraSelect(triggerId: 8001, enable: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_01_개방_이벤트_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_이벤트_00 : TriggerState {
            internal State관문_01_개방_이벤트_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_01_개방_이벤트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_이벤트_01 : TriggerState {
            internal State관문_01_개방_이벤트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2001, 2002}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_01_개방_이벤트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_이벤트_02 : TriggerState {
            internal State관문_01_개방_이벤트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2003}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_01_개방_이벤트_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_이벤트_03 : TriggerState {
            internal State관문_01_개방_이벤트_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2004}, arg2: true);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State관문_02_시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class State관문_02_스킵 : TriggerState {
            internal State관문_02_스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2001, 2002, 2003, 2004}, arg2: true);
                context.SetSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.RemoveBuff(boxId: 199, skillId: 70000107);
                    return new State관문_02_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_시작 : TriggerState {
            internal State관문_02_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.CameraSelect(triggerId: 8001, enable: false);
                context.ShowGuideSummary(entityId: 103, textId: 40011);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{6005, 6006, 6007, 6008}, visible: true);
                context.SetActor(triggerId: 3005, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 3006, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 3007, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 3008, visible: false, initialSequence: "Dmg_A");
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 101, textId: 40010);
                context.CreateMonster(spawnIds: new []{21, 22, 23, 24, 25, 26, 27}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{21, 22, 23, 24, 25, 26, 27})) {
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
                context.SetEventUI(arg1: 1, script: "$02000353_BF__MAIN__3$", duration: 2000);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_02_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State관문_02_개방_이벤트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방_이벤트_01 : TriggerState {
            internal State관문_02_개방_이벤트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2006}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_02_개방_이벤트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방_이벤트_02 : TriggerState {
            internal State관문_02_개방_이벤트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2007}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_02_개방_이벤트_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방_이벤트_03 : TriggerState {
            internal State관문_02_개방_이벤트_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2008}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_03_시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_시작_01 : TriggerState {
            internal State관문_03_시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 103, textId: 40011);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 101, textId: 40010);
                context.SetEffect(triggerIds: new []{6301, 6302}, visible: true);
                context.SetActor(triggerId: 3301, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 3302, visible: false, initialSequence: "Dmg_A");
                context.CreateMonster(spawnIds: new []{31, 32, 33}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{31, 32, 33})) {
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
                context.SetEventUI(arg1: 1, script: "$02000353_BF__MAIN__4$", duration: 2000);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_03_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State관문_03_개방_이벤트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방_이벤트_01 : TriggerState {
            internal State관문_03_개방_이벤트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2009}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_03_개방_이벤트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방_이벤트_02 : TriggerState {
            internal State관문_03_개방_이벤트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2010}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_03_개방_이벤트_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방_이벤트_03 : TriggerState {
            internal State관문_03_개방_이벤트_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2011}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State지역Clear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지역Clear : TriggerState {
            internal State지역Clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 103, textId: 40009);
                context.SetMesh(triggerIds: new []{6006}, visible: false, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{6007}, visible: true, arg4: 0, arg5: 10f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
