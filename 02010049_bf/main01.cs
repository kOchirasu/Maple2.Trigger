using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010049_bf {
    public static class _main01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: false);
                context.SetMesh(triggerIds: new []{10000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 20000, 30000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 9990, 9991, 9992, 9993, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{7000, 7001, 7002, 7003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102, 103, 104, 105, 107, 108, 201, 202, 203, 204, 205, 206}, arg2: false);
                context.ShowGuideSummary(entityId: 20104901, textId: 20104901, duration: 3000);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enable: true);
                context.SetSkip(state: new StateCameraWalk02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCameraWalk02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 600, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGateOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGateOpen01 : TriggerState {
            internal StateGateOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9990, 9991, 9992, 9993}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State전투지역01시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역01시작 : TriggerState {
            internal State전투지역01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104902, textId: 20104902, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102, 103, 104, 105, 107, 108})) {
                    return new State전투지역02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역02Wait : TriggerState {
            internal State전투지역02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{10000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104903, textId: 20104903, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new State전투지역02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역02시작 : TriggerState {
            internal State전투지역02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104902, textId: 20104902, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State전투지역02추가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역02추가 : TriggerState {
            internal State전투지역02추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104904, textId: 20104904, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204, 205, 206})) {
                    return new State전투지역03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역03Wait : TriggerState {
            internal State전투지역03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{20000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104903, textId: 20104903, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9003})) {
                    return new State전투지역03시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역03시작 : TriggerState {
            internal State전투지역03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{399, 302, 303, 304, 305, 306, 307, 309}, arg2: false);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104902, textId: 20104902, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{302, 303, 304, 305, 306, 307})) {
                    return new State전투지역04시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역04시작 : TriggerState {
            internal State전투지역04시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104904, textId: 20104904, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{309})) {
                    return new State퇴장Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장Cinematic01 : TriggerState {
            internal State퇴장Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{399});
                context.CreateMonster(spawnIds: new []{400}, arg2: false);
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_399");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 601, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State퇴장Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장Cinematic02 : TriggerState {
            internal State퇴장Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State퇴장Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장Cinematic03 : TriggerState {
            internal State퇴장Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8000, spawnIds: new []{400})) {
                    return new State다리Creation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Creation01 : TriggerState {
            internal State다리Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{400});
                context.SetMesh(triggerIds: new []{30000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(triggerIds: new []{7000, 7001, 7002, 7003}, visible: true, meshCount: 4, arg4: 100, delay: 100);
                context.ShowGuideSummary(entityId: 20104905, textId: 20104905, duration: 6000);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9010})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
