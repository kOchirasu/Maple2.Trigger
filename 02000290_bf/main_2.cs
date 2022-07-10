namespace Maple2.Trigger._02000290_bf {
    public static class _main_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{905, 906, 907, 908}, visible: true);
                context.SetLadder(triggerId: 531, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 532, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 533, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 534, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 535, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 536, visible: false, animationEffect: false);
                context.SetMesh(triggerIds: new []{3089}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3108}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 3110, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{3111, 3112, 3113, 3114, 3115, 3116, 3117}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 3120, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5101}, visible: false);
                context.DestroyMonster(spawnIds: new []{1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019});
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{6003, 6004, 6005, 6006}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001, 2002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateLadderCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation : TriggerState {
            internal StateLadderCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 20002903, textId: 20002903);
                context.SetEffect(triggerIds: new []{5101}, visible: true);
                context.SetLadder(triggerId: 531, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 532, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 533, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 534, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 535, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 536, visible: true, animationEffect: true);
                context.EnableSpawnPointPc(spawnId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 9991, isEnable: true);
                context.EnableSpawnPointPc(spawnId: 9992, isEnable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.HideGuideSummary(entityId: 20002903);
                    return new StateTrigger09시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger09시작 : TriggerState {
            internal StateTrigger09시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1011}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1011})) {
                    return new StateTrigger10시작(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateTrigger10시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger10시작 : TriggerState {
            internal StateTrigger10시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{905, 906}, visible: false);
                context.SetMesh(triggerIds: new []{3089}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209}, visible: true, arg3: 0, arg4: 200, arg5: 2f);
                context.CreateMonster(spawnIds: new []{1012, 1013}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1012, 1013})) {
                    return new StateTrigger11시작(context);
                }

                if (context.WaitTick(waitTick: 12000)) {
                    return new StateTrigger11시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger11시작 : TriggerState {
            internal StateTrigger11시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{907, 908}, visible: false);
                context.SetMesh(triggerIds: new []{3108}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, visible: true, arg3: 0, arg4: 200, arg5: 2f);
                context.CreateMonster(spawnIds: new []{1014, 1015, 1016}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1014, 1015, 1016})) {
                    return new StateTrigger12시작(context);
                }

                if (context.WaitTick(waitTick: 15000)) {
                    return new StateTrigger12시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger12시작 : TriggerState {
            internal StateTrigger12시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3110, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3111}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1017, 1018, 1019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger12진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger12진행 : TriggerState {
            internal StateTrigger12진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3110, visible: false, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3112, 3113, 3114, 3115, 3116, 3117}, visible: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1017, 1018, 1019})) {
                    return new StateTrigger13시작(context);
                }

                if (context.WaitTick(waitTick: 15000)) {
                    return new StateTrigger13시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger13시작 : TriggerState {
            internal StateTrigger13시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3120, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3121}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger13진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger13진행 : TriggerState {
            internal StateTrigger13진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3120, visible: false, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132}, visible: false, arg3: 0, arg4: 200, arg5: 2f);
                context.EnableSpawnPointPc(spawnId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 9991, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 9992, isEnable: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2002})) {
                    return new StateCinematicWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicWait : TriggerState {
            internal StateCinematicWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 801, enable: true);
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504}, visible: false, arg3: 0, arg4: 300, arg5: 3f);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{801}, returnView: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new State공주구출(context);
            }

            public override void OnExit() { }
        }

        private class State공주구출 : TriggerState {
            internal State공주구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 801, enable: false);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 20002904, textId: 20002904);
                context.SetInteractObject(interactIds: new []{10000464}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000464}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20002904);
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, script: "$02000290_BF__MAIN_2__2$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{910});
                context.CreateMonster(spawnIds: new []{911});
                context.CreateMonster(spawnIds: new []{912});
                context.CreateMonster(spawnIds: new []{913});
                context.CreateMonster(spawnIds: new []{914});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 910, patrolName: "MS2PatrolData910");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 911, patrolName: "MS2PatrolData911");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동03 : TriggerState {
            internal StateNPC이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 912, patrolName: "MS2PatrolData912");
                context.MoveNpc(spawnId: 914, patrolName: "MS2PatrolData914");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPC이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동04 : TriggerState {
            internal StateNPC이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 913, patrolName: "MS2PatrolData913");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNPCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01 : TriggerState {
            internal StateNPCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetConversation(type: 1, spawnId: 910, script: "$02000290_BF__MAIN_2__4$", arg4: 3);
                    context.SetEffect(triggerIds: new []{6003}, visible: true);
                    return new StateNPCScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript02 : TriggerState {
            internal StateNPCScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetConversation(type: 1, spawnId: 911, script: "$02000290_BF__MAIN_2__5$", arg4: 3);
                    context.SetEffect(triggerIds: new []{6004}, visible: true);
                    return new StateNPCScript03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript03 : TriggerState {
            internal StateNPCScript03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetConversation(type: 1, spawnId: 912, script: "$02000290_BF__MAIN_2__6$", arg4: 3);
                    context.SetEffect(triggerIds: new []{6005}, visible: true);
                    return new StateNPCScript04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript04 : TriggerState {
            internal StateNPCScript04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetConversation(type: 1, spawnId: 913, script: "$02000290_BF__MAIN_2__7$", arg4: 3);
                    context.SetEffect(triggerIds: new []{6006}, visible: true);
                    context.HideGuideSummary(entityId: 20002905);
                    return new StateEndWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndWait : TriggerState {
            internal StateEndWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 99999, type: "trigger", code: "ClearYomiprincess");
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
