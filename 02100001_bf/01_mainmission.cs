using Maple2.Trigger._dungeon_common;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02100001_bf {
    public static class _01_mainmission {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "10000");
                context.SetInteractObject(interactIds: new []{10001234, 10001235, 10001236, 10001237, 10001238}, state: 1);
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108});
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
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

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkuser10_guildraid.StateCheckUser10_GuildRaid(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 903, enable: true);
                context.SetCinematicIntro(text: "");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateShowCaption01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01 : TriggerState {
            internal StateShowCaption01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100001_BF__01_MAINMISSION__0$");
                context.SetSkip(state: new StateShowCaption01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateShowCaption01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01Skip : TriggerState {
            internal StateShowCaption01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateShowCaption02(context);
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02 : TriggerState {
            internal StateShowCaption02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100001_BF__01_MAINMISSION__1$");
                context.SetSkip(state: new StateShowCaption02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateShowCaption02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02Skip : TriggerState {
            internal StateShowCaption02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCloseCaptionSetting(context);
            }

            public override void OnExit() { }
        }

        private class StateCloseCaptionSetting : TriggerState {
            internal StateCloseCaptionSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CloseCinematic();
                context.CameraSelect(triggerId: 903, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDoorOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoorOpen : TriggerState {
            internal StateDoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99, key: "CageDoorOpen", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTalkStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkStart : TriggerState {
            internal StateTalkStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 900, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCinematicTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicTalk01 : TriggerState {
            internal StateCinematicTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003512, script: "$02100001_BF__01_MAINMISSION__2$", duration: 5000, align: Align.Center, illustId: "0");
                context.SetSkip(state: new StateCinematicTalk01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicTalk01Skip : TriggerState {
            internal StateCinematicTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCinematicTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematicTalk02 : TriggerState {
            internal StateCinematicTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003512, script: "$02100001_BF__01_MAINMISSION__3$", duration: 5000, align: Align.Center, illustId: "0");
                context.SetSkip(state: new StateCinematicTalk02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematicTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicTalk02Skip : TriggerState {
            internal StateCinematicTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateTalkEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateTalkEnd : TriggerState {
            internal StateTalkEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 900, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateTimmerStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimmerStart : TriggerState {
            internal StateTimmerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99, key: "MissionStart", value: 1);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetTimer(timerId: "10000", seconds: 300, clearAtZero: true, display: true, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001234}, arg2: 0) && context.ObjectInteracted(interactIds: new []{10001235}, arg2: 0) && context.ObjectInteracted(interactIds: new []{10001236}, arg2: 0) && context.ObjectInteracted(interactIds: new []{10001237}, arg2: 0) && context.ObjectInteracted(interactIds: new []{10001238}, arg2: 0)) {
                    return new StateMissionComplete(context);
                }

                if (context.TimeExpired(timerId: "10000")) {
                    return new StateMissionFail(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 5, key: "GiveBuffSlowly", value: 2);
            }
        }

        private class StateMissionFail : TriggerState {
            internal StateMissionFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "10000");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetEventUI(arg1: 5, script: "$02100001_BF__01_MAINMISSION__4$", duration: 3000);
                context.SetInteractObject(interactIds: new []{10001234, 10001235, 10001236, 10001237, 10001238}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMoveToCage(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToCage : TriggerState {
            internal StateMoveToCage(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02100001, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBadEndingStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBadEndingStart : TriggerState {
            internal StateBadEndingStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 901, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBadEndingTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBadEndingTalk01 : TriggerState {
            internal StateBadEndingTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003517, script: "$02100001_BF__01_MAINMISSION__5$", duration: 5000, align: Align.Center, illustId: "0");
                context.SetSkip(state: new StateBadEndingTalk01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBadEndingTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBadEndingTalk01Skip : TriggerState {
            internal StateBadEndingTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateBadEndingEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateBadEndingEnd : TriggerState {
            internal StateBadEndingEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 901, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeonFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFail : TriggerState {
            internal StateDungeonFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonFail();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBadEndingPortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBadEndingPortalOn : TriggerState {
            internal StateBadEndingPortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMissionComplete : TriggerState {
            internal StateMissionComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "10000");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetAchievement(triggerId: 9902, type: "trigger", code: "Find02100001");
                context.SetAchievement(triggerId: 9902, type: "trigger", code: "guildraid_clear_1");
                context.SetEventUI(arg1: 7, script: "$02100001_BF__01_MAINMISSION__6$", duration: 3000);
                context.SetUserValue(triggerId: 99, key: "MissionComplete", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateHappyEndingStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHappyEndingStart : TriggerState {
            internal StateHappyEndingStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 902, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateHappyEndingTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHappyEndingTalk01 : TriggerState {
            internal StateHappyEndingTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003512, script: "$02100001_BF__01_MAINMISSION__7$", duration: 5000, align: Align.Center, illustId: "0");
                context.SetSkip(state: new StateHappyEndingTalk01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateHappyEndingTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHappyEndingTalk01Skip : TriggerState {
            internal StateHappyEndingTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateHappyEndingEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateHappyEndingEnd : TriggerState {
            internal StateHappyEndingEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 902, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeonSuccess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonSuccess : TriggerState {
            internal StateDungeonSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateHappyEndingPortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHappyEndingPortalOn : TriggerState {
            internal StateHappyEndingPortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
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

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
