using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000248_bf {
    public static class _trigger_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110});
                context.SetEffect(triggerIds: new []{2001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 201) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{201})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{798, 799}, visible: false);
                context.SetTimer(timerId: "89", seconds: 3, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "89")) {
                    return new State공격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격 : TriggerState {
            internal State공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: true);
                context.SetEffect(triggerIds: new []{2001}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000248_BF__TRIGGER_01__0$", duration: 5000, boxId: 0);
                context.SetTimer(timerId: "1", seconds: 9, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103})) {
                    return new State공격1(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격1 : TriggerState {
            internal State공격1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104, 105}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{104, 105})) {
                    return new State공격2(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격2 : TriggerState {
            internal State공격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{106, 107, 108}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{106, 107, 108})) {
                    return new State공격2_2(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격2_2 : TriggerState {
            internal State공격2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{109, 110}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{109, 110})) {
                    return new State공격3(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격3 : TriggerState {
            internal State공격3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{114, 115, 116}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{114, 115, 116})) {
                    return new State공격3_2(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격3_2 : TriggerState {
            internal State공격3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111, 112, 113}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111, 112, 113})) {
                    return new State공격3_3(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격3_3 : TriggerState {
            internal State공격3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{117, 118, 119, 120}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{117, 118, 119, 120})) {
                    return new State공격4(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격4 : TriggerState {
            internal State공격4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{121, 122, 123, 124, 125}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{121, 122, 123, 124, 125})) {
                    return new State공격4_2(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격4_2 : TriggerState {
            internal State공격4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{126, 127, 128, 129, 130}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{126, 127, 128, 129, 130})) {
                    return new State공격5(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격5 : TriggerState {
            internal State공격5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{131, 132, 133, 134, 135, 136}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{131, 132, 133, 134, 135, 136})) {
                    return new State공격5_2(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격5_2 : TriggerState {
            internal State공격5_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{137, 138, 139, 140}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{137, 138, 139, 140})) {
                    return new State공격6(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격6 : TriggerState {
            internal State공격6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{141, 142, 143, 144, 145, 146, 148}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{141, 142, 143, 144, 145, 146, 148})) {
                    return new State공격7(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격7 : TriggerState {
            internal State공격7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{151, 153, 154, 155, 156, 157, 158}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{151, 153, 154, 155, 156, 157, 158})) {
                    return new State공격8(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격8 : TriggerState {
            internal State공격8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{161, 162, 163, 164, 167, 168, 169, 170}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.DestroyMonster(spawnIds: new []{161, 162, 163, 164, 167, 168, 169, 170});
                    return new State끝Cinematic(context);
                }

                if (!context.UserDetected(boxIds: new []{999})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝Cinematic : TriggerState {
            internal State끝Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8001, 8003, 8002}, returnView: false);
                context.SetTimer(timerId: "1", seconds: 4, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000249, portalId: 2);
                context.SetTimer(timerId: "1", seconds: 3, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State2차진입Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차진입Wait : TriggerState {
            internal State2차진입Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 15, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
